using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Player;
    public Vector3 offsets;
    // Update is called once per frame
    void Update()
    {   
        transform.position = Player.position+offsets;
    }
}
