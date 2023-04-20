using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrownzFPP
{
    public class BattlePositions : MonoBehaviour
    {
        [SerializeField] Transform[] alliesPositions;
        [SerializeField] Transform[] enemiesPositions;

        public void PositionCharacter(Character character, int pos, bool allie)
        {
            character.transform.SetParent(allie == true ? alliesPositions[pos] : enemiesPositions[pos]);
            Vector3 position = Vector3.zero;
            character.transform.localPosition = position;
            character.transform.localRotation = Quaternion.Euler(0, allie ? 180 : 0, 0);
        }
    }
}
