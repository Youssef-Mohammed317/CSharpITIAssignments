using Day8.Q1;

namespace Day8
{
    public partial class Form1 : Form
    {
        List<Lab> labs = new List<Lab>();
        List<Trainee> trainees = new List<Trainee>();
        public Form1()
        {
            InitializeComponent();

            CreateLabs();

            LoadLabs();

            CreateTrainee();

            LoadTrainees();

            //LoadTraineesLabs();
        }

        void CreateTrainee()
        {
            trainees.Add(new Trainee("Ali"));
            trainees.Add(new Trainee("Ahmed"));
            trainees.Add(new Trainee("Youssef"));
            trainees.Add(new Trainee("Mohammad"));
            trainees.Add(new Trainee("Lofy"));
            trainees.Add(new Trainee("Nami"));
            trainees.Add(new Trainee("Zoro"));
            trainees.Add(new Trainee("Yassin"));
            trainees.Add(new Trainee("Hossam"));
        }
        void LoadTrainees()
        {
            //this.traineesList.DisplayMember = "Name";
            //this.traineesList.Items.AddRange(trainees);

            foreach (Trainee trainee in trainees)
            {
                bool flag = true;
                foreach (Lab lab in labs)
                {
                    if (lab.Name == trainee.LabName)
                    {
                        lab.Trainees.Add(trainee);
                        if (lab.Name == ((Lab)cmbLabBx.SelectedItem).Name)
                            labList.Items.Add(trainee);
                        flag = false;
                        break;
                    }


                }
                if (flag) traineesList.Items.Add(trainee);
            }
        }

        void AdjustTraineesLabs()
        {
            foreach (Trainee trainee in trainees)
            {
                if (trainee.LabName == ((Lab)cmbLabBx.SelectedItem).Name)
                {
                    if (!labList.Items.Contains(trainee))
                         labList.Items.Add(trainee);
                }
                else
                {
                    if (labList.Items.Contains(trainee))
                        labList.Items.Remove(trainee);
                }
            }
        }

        void CreateLabs()
        {
            labs.Add(new Lab("Lab1"));
            labs.Add(new Lab("Lab2"));
            labs.Add(new Lab("Lab3"));
        }

        void LoadLabs()
        {
            this.cmbLabBx.DataSource = labs;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labList.Items.Clear();
            AdjustTraineesLabs();
        }

        private void MoveToLabBtn_Click(object sender, EventArgs e)
        {
            foreach (Trainee trainee in traineesList.CheckedItems)
            {
                trainee.setLab(cmbLabBx.SelectedItem);
            }

            AdjustTraineesLabs();
            AdjustTraineeListAfterChange();
        }

        private void AdjustTraineeListAfterChange()
        {
            traineesList.Items.Clear();
            foreach (Trainee trainee in trainees)
            {
                if (trainee.LabName == string.Empty || trainee.LabName == null)
                {
                    traineesList.Items.Add(trainee);
                }
            }
        }

        private void MoveAllToLab_Click(object sender, EventArgs e)
        {
            foreach (Trainee trainee in traineesList.Items)
            {
                trainee.setLab(cmbLabBx.SelectedItem);
            }

            AdjustTraineeListAfterChange();

            AdjustTraineesLabs();
        }

        private void MoveFromLab_Click(object sender, EventArgs e)
        {
            foreach (Trainee trainee in labList.CheckedItems)
            {
                trainee.removeLab();
            }

            AdjustTraineeListAfterChange();
            AdjustTraineesLabs();
        }

        private void MoveAllFromLab_Click(object sender, EventArgs e)
        {
            foreach (Trainee trainee in labList.Items)
            {
                trainee.removeLab();
            }

            AdjustTraineeListAfterChange();
            AdjustTraineesLabs();
        }
    }
}
