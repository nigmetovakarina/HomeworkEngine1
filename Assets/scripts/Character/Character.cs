using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private CharacterData characterData;

    
    public IHealthComponent HealthComponent { get; protected set; }



    public abstract void Initialize();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
