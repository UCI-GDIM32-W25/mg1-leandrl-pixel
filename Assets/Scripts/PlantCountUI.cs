using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        Debug.Log( "UpdateSeeds Left" + seedsLeft + "Planted: " +  seedsPlanted );
        _remainingText.text = "Seeds Left:" + seedsLeft;
        _plantedText.text = "Seeds Planted:" + seedsPlanted; 
    }
}