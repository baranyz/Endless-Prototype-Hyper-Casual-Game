using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialOffset : MonoBehaviour
{
    MeshRenderer mr;
    [SerializeField] float offSetSpeed;

    private void Start() {
        mr = GetComponent<MeshRenderer>();
    }
    private void Update() {
        
        mr.material.mainTextureOffset = new Vector2(0, -Time.realtimeSinceStartup/offSetSpeed);

    }
}
