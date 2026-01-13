using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5;
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

    }

    private void Update()
    {
        HandleMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }

    }

    private void HandleMovement() 
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY); 

        transform.Translate(movement * _speed * Time.deltaTime);
    
    }



    public void PlantSeed ()
    {
        if (_numSeedsLeft <= 0)
            return; 

        Instantiate(_plantPrefab, transform.position, Quaternion.identity);
        _numSeedsLeft--;
        _numSeedsPlanted++;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted); 
        //_plantPrefab.SetActive(true);
    }
}
