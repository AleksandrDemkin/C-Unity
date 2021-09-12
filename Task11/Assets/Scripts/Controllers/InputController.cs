using RollABall.SaveDirectory;
using UnityEngine;

namespace RollABall
{
    public sealed class InputController : IExecute
    {
        private readonly PlayerBase _playerBase;
        private readonly InputData _inputData;
        private readonly ISaveDataRepository _saveDataRepository;
        private readonly Repository _repository;
        
        public InputController(PlayerBase player, InputData inputData)
        {
            _playerBase = player;
            _inputData = inputData;

            _saveDataRepository = new SaveDataRepository();
            _repository = new Repository();
            new ControllerTest1(_repository);
            new ControllerTest2(_repository);
        }

        public void Execute()
        {
            _playerBase.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKeyDown(_inputData.SavePlayer))
            {
                _saveDataRepository.Save(_playerBase);
            }
            if (Input.GetKeyDown(_inputData.LoadPlayer))
            {
                _saveDataRepository.Load(_playerBase);
            }
        }
    }
}