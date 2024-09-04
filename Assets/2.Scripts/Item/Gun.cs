using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject muzzel;
    [SerializeField] private GunSO gunSO;

    private int ammo;                   //���� �Ѿ� - - -
    private int ammoCapacity;           //�Ѿ� �뷮(/źâ)    o
    private int maxAmmo;                //�ִ� �Ѿ�     o
    private float reloadTime;           //������ �ð�    o
    private float fireRate;             //���� �ӵ�     o
    private bool auto;                  //��� ���     o

    private float spreadAngle;          //ź ���� ����

    private GunSO.GunType _gunType = new GunSO.GunType();
    private void Start()
    {
        _gunType = GunSO.GunType.Rifle;
        SettingGun();
    }
    private void SettingGun()
    {
        switch (_gunType)
        {
            case GunSO.GunType.Rifle:
                ammoCapacity = gunSO.r_ammoCapacity;
                maxAmmo = gunSO.r_maxAmmo;
                reloadTime = gunSO.r_reloadTime;
                fireRate = gunSO.r_fireRate;
                auto = gunSO.r_auto;
                spreadAngle = gunSO.r_spreadAngle;
                break;
            case GunSO.GunType.Shotgun:
                ammoCapacity = gunSO.s_ammoCapacity;
                maxAmmo = gunSO.s_maxAmmo;
                reloadTime = gunSO.s_reloadTime;
                fireRate = gunSO.s_fireRate;
                auto = gunSO.s_auto;
                spreadAngle = gunSO.s_spreadAngle;
                break;
            case GunSO.GunType.Pistol:
                ammoCapacity = gunSO.p_ammoCapacity;
                maxAmmo = gunSO.p_maxAmmo;
                reloadTime = gunSO.p_reloadTime;
                fireRate = gunSO.p_fireRate;
                auto = gunSO.p_auto;
                spreadAngle = gunSO.p_spreadAngle;
                break;
        }
    }

    private void LoadGun()
    {
        //�� sprite �����ϱ�
    }
    public void Fire()
    {
        spawnBullet();
    }
    private void spawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, muzzel.transform.position, transform.rotation, null);
    }
}
