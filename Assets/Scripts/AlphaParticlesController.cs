using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaParticlesController : MonoBehaviour
{
    [SerializeField] ParticleSystem alphaParticles;

    private void Awake()
    {
        ToggleTrace(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetAlphaParticlesEnergy(float value)
    {
        ParticleSystem.MainModule main = alphaParticles.main;
        main.startSpeed = value;
    }

    public void ToggleTrace(bool value)
    {
        ParticleSystem.TrailModule trails = alphaParticles.trails;
        trails.enabled = value;
    }
}
