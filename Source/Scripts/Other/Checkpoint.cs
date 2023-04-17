using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private List<QuadcopterController> _checkedCopters = new List<QuadcopterController>();
    [SerializeField] GameObject _checkParticle;
    [SerializeField] Transform _spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        var copter = other.GetComponent<QuadcopterController>();
        if(copter)
        {
            if (_checkedCopters.Contains(copter))
                return;
            _checkedCopters.Add(copter);
            Destroy(Instantiate(_checkParticle, transform), 3);
            copter.lastCheckpoint = _spawnPoint;
            copter.AddPoints(1);
        }
    }
}
