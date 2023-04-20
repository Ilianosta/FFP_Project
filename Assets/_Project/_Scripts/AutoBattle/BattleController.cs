using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
namespace KrownzFPP
{
    public class BattleController : MonoBehaviour
    {
        [SerializeField] BattlePositions battlePositions;
        [SerializeField] List<Character> characters = new List<Character>();
        List<Character> turnOrder = new List<Character>();
        void Awake()
        {
            battlePositions = GetComponent<BattlePositions>();
        }
        void Start()
        {
            ChargeCharacters(characters);
            InitBattle();
        }
        public void ChargeCharacters(List<Character> battlers)
        {
            // characters.AddRange(battlers);
            int i = 0;
            bool allie = true;
            foreach (Character character in characters)
            {
                battlePositions.PositionCharacter(character, i, allie);
                character.OnSpeedChanged += ActualizarVelocidades;
                i++;
                if (i > 4)
                {
                    i = 0;
                    allie = false;
                }
            }
        }
        void ActualizarVelocidades()
        {
            // Ordena la lista por velocidad descendente
            turnOrder.Sort((a, b) => b.Speed.CompareTo(a.Speed));
        }
        public void InitBattle()
        {
            turnOrder.AddRange(characters);

            // Ordena la lista por velocidad descendente
            turnOrder.Sort((a, b) => b.Speed.CompareTo(a.Speed));
        }

        void Update()
        {
            // Verifica si algún personaje puede actuar
            if (turnOrder.Count > 0)
            {
                // Toma el siguiente personaje en la lista
                var personaje = turnOrder[0];
                turnOrder.RemoveAt(0);

                // Hace que el personaje ataque
                personaje.Attack();
            }
        }
    }
}
