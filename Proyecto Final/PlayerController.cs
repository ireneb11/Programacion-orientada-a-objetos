using UnityEngine;     //Importa el motor de Unity.
using UnityEngine.InputSystem;  // Permite usar el nuevo sistema de input de Unity

public class PlayerController : MonoBehaviour   // clase llamada PlayerController.
                                                // Hereda de MonoBehaviour, lo que permite que sea un script que se puede añadir a un GameObject.
{
  // VARIABLES 
    private CharacterController _characterController;  // referencia al componente físico que mueve al jugador   Componente que mueve al personaje detecta colisiones y evita atravesar paredes
    public float MovementSpeed = 10f, RotationSpeed = 5f;       //         MovementSpeed → velocidad de desplazamiento
    // Al ser públicas: Se pueden modificar desde el Inspector             RotationSpeed → velocidad de giro

    private float _rotationY;  // ángulo acumulado en el eje Y.  Imagina que empieza mirando al norte (0°).Si giras un poco a la derecha → ahora está a 10°

  
    void Start()   // Se ejecuta una sola vez cuando empieza el juego.
    {
        _characterController = GetComponent<CharacterController>();   // Busca en el  objeto (jugador) el componente CharacterController y lo guarda.
    }

    // Update is called once per frame
    public void Move(Vector2 movementVector)   //Recibe un vector 2D:  movementVector.x → izquierda/derecha     movementVector.y → adelante/atrás 
                                                // Si presionas W: movementVector = (0, 1)
    {
        Vector3 move = transform.forward * movementVector.y + transform.right * movementVector.x;   // combinación lineal de vectores . 👉 "Muévete hacia delante según lo que pulses en Y" . Si pulso W + D: move = forward + right
                // transform.forward --> vector que apunta hacia delante del jugador.  Si el jugador mira al norte: forward = (0,0,1) 
                // transform.right --> vector que apunta hacia la derecha del jugador.

                // ¿Por qué usamos forward y no Vector3.forward? Vector3.forward siempre apunta al norte global.
                                                                // transform.forward apunta hacia donde el jugador esté mirando.

      
        move = move * MovementSpeed*Time.deltaTime;   // Primero multiplica por la velocidad (que tan rapido se mueve ) y uego por tiempo entre frames.   -->hace que el movimiento no dependa de los FPS.
        _characterController.Move(move);   // Le dice al componente físico que se desplace esa cantidad
    }

  ?????
    public void Rotate(Vector2 rotationVector)   // Recibe un vector de rotación.  Solo usa el eje X (izquierda/derecha).
    {
        _rotationY += rotationVector.x * RotationSpeed * Time.deltaTime;  // θ=θ+ω⋅Δt
        transform.localRotation = Quaternion.Euler(0, _rotationY, 0);  //Convierte los grados en una rotación 3D.
        //rotates on y axis based on left and right input                 Rota solo en eje Y (horizontal).
    
    }




-----------------------------------------------------------------------------
👉 Lee el input (teclado/ratón o mando)
👉 Se lo pasa al PlayerController
  
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHangler : MonoBehaviour
{
    public PlayerController CharacterController;    // referencia a tu script PlayerController (en el inspector se arrastra el script)
    private InputAction _moveAction, _lookAction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _moveAction = InputSystem.actions.FindAction("Move");  // Busca en el archivo de Input Actions una acción llamada:"Move"
        _lookAction = InputSystem.actions.FindAction("Look");
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = _moveAction.ReadValue<Vector2>();
      /*Lee lo que está pulsando el jugador.
      W → (0,1)
      S → (0,-1)
      D → (1,0)
      A → (-1,0)
      */
        CharacterController.Move(movementVector);  // Le dice al otro script: 👉 “Toma este vector y muévete.”
        Vector2 lookVector = _lookAction.ReadValue<Vector2>();   
        CharacterController.Rotate(movementVector);    
    }
}

}
