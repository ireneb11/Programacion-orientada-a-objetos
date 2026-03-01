using UnityEngine;     //Importa el motor de Unity.
using UnityEngine.InputSystem;  // Permite usar el nuevo sistema de input de Unity

public class PlayerController : MonoBehaviour   // clase llamada PlayerController.
                                                // Hereda de MonoBehaviour, lo que permite que sea un script que se puede añadir a un GameObject.
{
  // VARIABLES 
    private CharacterController _characterController;  // referencia al componente físico que mueve al jugador
    public float MovementSpeed = 10f, RotationSpeed = 5f;       //         MovementSpeed → velocidad de desplazamiento
    // Al ser públicas: Se pueden modificar desde el Inspector             RotationSpeed → velocidad de giro

    private float _rotationY;  // ángulo acumulado en el eje Y
    void Start()   // Se ejecuta una sola vez cuando empieza el juego.
    {
        _characterController = GetComponent<CharacterController>();   // Busca en el mismo objeto el componente CharacterController y lo guarda.
    }

    // Update is called once per frame
    public void Move(Vector2 movementVector)   //Recibe un vector 2D:  movementVector.x → izquierda/derecha     movementVector.y → adelante/atrás
    {
        Vector3 move = transform.forward * movementVector.y + transform.right * movementVector.x;   // combinación lineal de vectores (álgebra lineal pura).
        move = move * MovementSpeed*Time.deltaTime;   // Primero multiplica por la velocidad y uego por tiempo entre frames.   -->hace que el movimiento no dependa de los FPS.
        _characterController.Move(move);   // Le dice al componente físico que se desplace esa cantidad
    }
    public void Rotate(Vector2 rotationVector)   // Recibe un vector de rotación.  Solo usa el eje X (izquierda/derecha).
    {
        _rotationY += rotationVector.x * RotationSpeed * Time.deltaTime;  // θ=θ+ω⋅Δt
        transform.localRotation = Quaternion.Euler(0, _rotationY, 0);  //Convierte los grados en una rotación 3D.
        //rotates on y axis based on left and right input                 Rota solo en eje Y (horizontal).
    
    }
}
