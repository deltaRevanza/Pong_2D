using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            if(!isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored!!!");
                GameObject.Find("GameManager").GetComponent<GameManagerScript>().Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 Scored!!!");
                GameObject.Find("GameManager").GetComponent<GameManagerScript>().Player1Scored();
            }
        }
    }
}
