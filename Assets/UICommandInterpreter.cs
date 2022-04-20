using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace WA.UI
{
    public class UICommandInterpreter : MonoBehaviour
    {
        [SerializeField] private UICommandHistory _commandHistory;
        [SerializeField] private TMP_InputField _inputField;

        public void Interpret(string command)
        {
            _commandHistory.AddCommand(command);
            _inputField.text = "";
        }
    }
}