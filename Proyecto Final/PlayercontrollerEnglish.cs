using UnityEngine;     //Importa el motor de Unity.
using UnityEngine.InputSystem;  // Permite usar el nuevo sistema de input de Unity

public class PlayerController : MonoBehaviour   // clase llamada PlayerController.
                                                // Hereda de MonoBehaviour, lo que permite que sea un script que se puede añadir a un GameObject.
{
  // VARIABLES 
    private CharacterController _characterController;  // Public variable that references Unity’s CharacterController component
                                                  // This component handles movement and collision detection. Prevents the player from walking through walls
    public float MovementSpeed = 10f, RotationSpeed = 5f;       //       Public variable MovementSpeed --> Controls how fast the player moves. Can be modified in the Inspector
    // Al ser públicas: Se pueden modificar desde el Inspector             RotationSpeed → how fast the player rotates

    private float _rotationY;  // ángulo acumulado en el eje Y.  Imagina que empieza mirando al norte (0°).Si giras un poco a la derecha → ahora está a 10°

  
    void Start()   // Runs once when the game starts
    {
        _characterController = GetComponent<CharacterController>();   // Gets the CharacterController component attached to this GameObject. Stores the reference so it can be used for movement
    }

   
    public void Move(Vector2 movementVector)   //Recibe un vector 2D:  movementVector.x → izquierda/derecha     movementVector.y → adelante/atrás 
                                                // Si presionas W: movementVector = (0, 1)
    {
        Vector3 move = transform.forward * movementVector.y + transform.right * movementVector.x;   // Creates a 3D movement vector using a linear combination of:
                // transform.forward --> (direction the player is facing.  Si el jugador mira al norte: forward = (0,0,1) 
                // transform.right --> direction to the right of the player.

                // ¿Por qué usamos forward y no Vector3.forward? Vector3.forward siempre apunta al norte global.
                                                                // transform.forward This makes movement relative to the player's orientation

      
        move = move * MovementSpeed*Time.deltaTime;   // Multiplies the movement vector by MovementSpeed. Controls how fast the player moves.
                                                          // Multiplies by Time.deltaTime  - Makes movement independent of FPS
      _characterController.Move(move);   // Moves the player using the CharacterController

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
        Vector2 lookVector = _lookAction.ReadValue<Vector2>();   // lee el raton o joystick
        CharacterController.Rotate(movementVector);    
    }
}

}
