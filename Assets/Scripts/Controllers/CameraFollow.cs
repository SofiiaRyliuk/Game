using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Hero hero;

    void Update()
    {
        Transform hero_transform = hero.transform;
        Transform camera_transform = this.transform;

        Vector3 hero_position = hero_transform.position;
        Vector3 camera_position = camera_transform.position;

        camera_position.x = hero_position.x;
        camera_position.y = hero_position.y;

        camera_transform.position = camera_position;
    }
}