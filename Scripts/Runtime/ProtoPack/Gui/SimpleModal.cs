using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ProtoPack.Gui
{
    public class SimpleModal : ModalBase<SimpleModal.Result>
    {
        public enum Result
        {
            Ok,
            Cancel
        }

        [SerializeField] private Button _okButton;
        [SerializeField] private Button _cancelButton;
        [SerializeField] private CanvasGroup _canvasGroup;

        private void OnEnable()
        {
            _okButton.onClick.AddListener(OkButtonClick);
            _cancelButton.onClick.AddListener(CancelButtonClick);
        }

        private void OnDisable()
        {
            _okButton.onClick.RemoveListener(OkButtonClick);
            _cancelButton.onClick.RemoveListener(CancelButtonClick);        
        }

        private async void OnGUI()
        {
            if (GUILayout.Button("Show Modal"))
            {
                var result = await Show();
                Debug.Log(result);
            }
        }

        protected override Task<Result> Show()
        {
            _canvasGroup.alpha = 1.0f;
            return base.Show();
        }

        private void OkButtonClick()
        {
            SetResultAndHide(Result.Ok);
        }

        private void CancelButtonClick()
        {
            SetResultAndHide(Result.Cancel);
        }
    }
}