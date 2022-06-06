namespace Greed{

    class Director{
        Random Random = new Random();
        private bool Playing = true;
        public Director(){}

        public void StartGame(){

            while(Playing){
                
                GetInputs();
                DoUpdates();
                DoOutputs();


            }        
        }
        private void GetInputs(){
            
        }
        private void DoUpdates(){

        }
        private void DoOutputs(){

        }
        private void Create_RG(){
            CreateRock();
            CreateGem();
        }
        private void CreateRock(){

        }
        private void CreateGem(){

        }
    }
}