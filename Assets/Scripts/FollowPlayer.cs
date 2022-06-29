using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float offSetZ;
    [SerializeField] private float smoothCamera;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ToFollowPlayer();
    }

    private void ToFollowPlayer()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z - offSetZ);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothCamera * Time.deltaTime);
    }
}
