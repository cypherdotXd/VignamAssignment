using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour
{
    [SerializeField] private int protons = 2;
    [SerializeField] private int neutrons = 2;
    [SerializeField] private ParticleSystem neutronsParticles;
    [SerializeField] private ParticleSystem protonsParticles;
    [SerializeField] private ParticleSystemForceField positiveForceField;

    private void Awake()
    {
        // 
        SetProtonCount(protons);
        SetNeutronCount(neutrons);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetProtonCount(float count)
    {
        neutronsParticles.Clear();
        neutronsParticles.Emit((int)count);
        ParticleSystem.ShapeModule shape = neutronsParticles.shape;
        shape.radius = count / 30;
        positiveForceField.endRange = count / 30 + 0.5f;
    }

    public void SetNeutronCount(float count)
    {
        protonsParticles.Clear();
        protonsParticles.Emit((int)count);
        ParticleSystem.ShapeModule shape = protonsParticles.shape;
        shape.radius = count / 30;
        positiveForceField.endRange = count / 30 + 0.5f;
    }
}