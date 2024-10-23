using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;
    [SerializeField] int nbrofbullets = 20;
    [SerializeField] private Transform BulletSpawn;
    [SerializeField] private TMP_Text nubreofbulletdisplay;
    [SerializeField] private bool isReloading;

    private PlayerControle _playerControl;


    void Awake()
    {
        _playerControl = new PlayerControle();
    }
    private void OnEnable()
    {
        _playerControl.Enable();
    }
    private void OnDisable()
    {
        _playerControl.Disable();
    }
    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        GunBehaviour();
        if (_playerControl.Land.Gunreloading.IsPressed() && nbrofbullets < 20)
        {
            isReloading = true;
            Invoke("ReloadBullets",2f);
        }
        nubreofbulletdisplay.text=nbrofbullets.ToString();
    }
    public void GunBehaviour()
    {
        if (_playerControl.Land.Gunshooting.IsPressed() && nbrofbullets > 0 && !isReloading)
        {
            Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);
            nbrofbullets--;
        } else if (_playerControl.Land.Gunshooting.IsPressed() && nbrofbullets == 0)
        {
            isReloading=true;
            Invoke("ReloadBullets", 2f);
        }
    }
    public void ReloadBullets()
    {
        nbrofbullets = 20;
        isReloading = false;
    }
}
