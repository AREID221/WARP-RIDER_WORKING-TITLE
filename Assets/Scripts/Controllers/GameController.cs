using UnityEngine;

public class GameController : MonoBehaviour
{
    #region VARS
    private int _credits;
    private bool _gameOver;
    private Player _player;
    #endregion

    void Start()
    {
        //_gameOver = false;
        _credits = 3;
        _player = GameObject.Find("Player").GetComponent<Player>(); // Should not be using this method of grabbing reference but does trick for testing!!
    }

    private void Update()
    {
        if (_player.dead == true)
        {
            if (_credits > 0)
            {
                _credits -= 1;
                _player.Respawn();
                Debug.Log("Remaining credits: " + _credits);
            }           
        }

        if (_credits <= 0)
        {
            _player.transform.position = new Vector3(2, 0, 0);
            _player.dead = true;
        }
    }
}
