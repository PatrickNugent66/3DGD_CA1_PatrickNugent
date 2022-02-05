using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnterArea : MonoBehaviour
{
    /// <summary>
    /// Sends the player object inside/outside the
    /// apartment depending on which trigger was entered
    /// once the player enters the trigger
    /// </summary>
    /// <param name="other">
    /// the player object
    /// </param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && gameObject.tag.Equals("EnterTrigger"))
        {
            //Temporarily disable any components that prevent 
            //changing the player's position
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<NavMeshAgent>().enabled = false;

            other.transform.position = new Vector3(104.283f, 0.029f, 90.529f);

            StartCoroutine(EnableComponents(other.gameObject));
        }
        else if(other.gameObject.tag.Equals("Player") && gameObject.tag.Equals("ExitTrigger"))
        {
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<NavMeshAgent>().enabled = false;

            other.transform.position = new Vector3(105.269f, 0.249f, 75f);

            StartCoroutine(EnableComponents(other.gameObject));
        }
    }

    /// <summary>
    /// Enables the player's components again for
    /// handling collisions and movement
    /// </summary>
    /// <param name="player">
    /// the player object
    /// </param>
    protected IEnumerator EnableComponents(GameObject player)
    {
        yield return new WaitForSeconds(0.5f);
        player.GetComponent<BoxCollider>().enabled = true;
        player.GetComponent<NavMeshAgent>().enabled = true;
    }
}
