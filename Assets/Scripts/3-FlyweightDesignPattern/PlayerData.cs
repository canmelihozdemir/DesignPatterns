using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Flyweight
{
    [CreateAssetMenu(fileName ="NewPlayerData",menuName ="Create Player Data")]
    public class PlayerData : ScriptableObject
    {
        private float _maxSpeed = 50f;
        private float _attackRange = 40f;
        private float _attackInterval = 3f;
        private float _maxHp = 100f;

        public float MaxSpeed => _maxSpeed;
        public float AttackRange => _attackRange;
        public float AttackInterval => _attackInterval;
        public float MaxHp => _maxHp;

    }

}
