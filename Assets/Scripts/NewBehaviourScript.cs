using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    NavMeshAgent myNavMeshAgent;
    public GameObject jugador;

    // A�adido: referencia al componente Animator
    public Animator animator;

    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>(); // Obtener la referencia al Animator en el mismo GameObject
        // myNavMeshAgent.enabled = true; // No es necesario habilitar ya que se activa por defecto
    }

    void FixedUpdate()
    {
        if (myNavMeshAgent.enabled)
        {
            myNavMeshAgent.SetDestination(jugador.transform.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myNavMeshAgent.enabled = true;

            // A�adido: activar la animaci�n de caminar
            animator.SetBool("Walk", true);
        }
    }
}
