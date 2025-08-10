using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class enemycontroller : MonoBehaviour
{
    private float end;
    private bool isinhitbox = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        end += Time.deltaTime;
        if (isinhitbox == true && playercontroller.isshooting == true)
        {
            if (playercontroller.wavestart == true)
            {
                playercontroller.score += 1;

            }


            Destroy(gameObject);
        }
        if (end >= 1.2f)
            {
                Destroy(gameObject);
            }   

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hitdetector"))
        {
            isinhitbox = true;
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hitdetector"))
        {
            isinhitbox = false;
        }

    }
}
