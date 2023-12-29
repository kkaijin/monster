using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class target : MonoBehaviour
{
    public static int killC = 0;
    TextMeshProUGUI kill_text;
    public float health = 50f;
    GameObject text_object;

    NavMeshAgent agent;


    GameObject Timer_object;

    Timer1 Timer_script;

    GameObject player_object;

    Transform player_transform;

    GameObject effect_shoot;

    ParticleSystem shoot;

    float distance = 0;

    void Start()
    {
        text_object = GameObject.Find("killsn");
        kill_text = text_object.GetComponent<TextMeshProUGUI>();
         
        Timer_object = GameObject.Find("Timer");
        Timer_script = Timer_object.GetComponent<Timer1>();

        agent = GetComponent<NavMeshAgent>();

        player_object = GameObject.Find("terControllerroller");
        player_transform = player_object.GetComponent<Transform>();

        effect_shoot = GameObject.Find("LightEnemy");
        shoot = effect_shoot.GetComponent<ParticleSystem>();

    }

    void Update()
    {   
        distance = Vector3.Distance(player_transform.position, transform.position);
        if (distance <= 8f ) {
            agent.SetDestination(player_transform.position);
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, 50f))
            {
                shoot.Play();
                if (hit.transform.name == "terControllerroller")
                {
                    print("popsal");
                }
            }
        }
        
        
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            killC++;
            kill_text.text = killC.ToString();
            if(killC == 10) {
                print("kill");
                Timer_script.allEnemeiesDestroyed = true;
            }
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
        
    }

    

}
