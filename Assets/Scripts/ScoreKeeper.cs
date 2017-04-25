using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts {
    public class ScoreKeeper : MonoBehaviour
    {

        public HealthManager healthManager;
        private Text text;
        // Use this for initialization
        void Start()
        {
            text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            text.text = "Score: " + (healthManager.MaxHp - healthManager.currentHp) * 100;
        }
    }
}
