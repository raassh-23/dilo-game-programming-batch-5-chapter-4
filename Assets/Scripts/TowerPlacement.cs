﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    private Tower _placedTower;

    private void OnTriggerEnter2D(Collider2D other) {
        if(_placedTower != null) {
            return;
        }

        Tower tower = other.GetComponent<Tower>();
        if (tower != null) {
            tower.SetPlacePosition(transform.position);
            _placedTower = tower;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (_placedTower == null) {
            return;
        }

        _placedTower.SetPlacePosition(null);
        _placedTower = null;
    }
}
