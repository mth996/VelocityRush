using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    public List<Transform> carTransformList;
    private List<CheckpointSingle> checkpointSingleList;
    private List<int> nextCheckpointSingleIndexList;
    public List<int> lapcountList;
    private void Start()
    {
        carTransformList = GameObject.FindGameObjectsWithTag("Player").Select(x => x.GetComponent<Transform>()).ToList();

        nextCheckpointSingleIndexList = new List<int>();
        foreach (Transform carTransform in carTransformList)
        {
            nextCheckpointSingleIndexList.Add(0);
            lapcountList.Add(0);
        }
    }
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");
        checkpointSingleList = new List<CheckpointSingle>();

        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();

            checkpointSingle.SetTrackCheckpoints(this);

            checkpointSingleList.Add(checkpointSingle);
        }
    }

    public void CarThroughCheckpoint(CheckpointSingle checkpointSingle, Transform carTransform, bool lapchecker)
    {
        int nextCheckpointSingleIndex = nextCheckpointSingleIndexList[carTransformList.IndexOf(carTransform)];
        if (checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            Debug.Log("Correct");
            nextCheckpointSingleIndexList[carTransformList.IndexOf(carTransform)]
                = (nextCheckpointSingleIndex + 1) % checkpointSingleList.Count;
            if (lapchecker == true)
            {
                lapcountList[carTransformList.IndexOf(carTransform)]++;
                if (lapcountList[carTransformList.IndexOf(carTransform)] >= 2)
                {
                    FindObjectOfType<GameManager>().WinGame();
                }

            }
        }
        
        else
        {
            // Wrong Checkpoint
            Debug.Log("Wrong");
        }
    }
}
