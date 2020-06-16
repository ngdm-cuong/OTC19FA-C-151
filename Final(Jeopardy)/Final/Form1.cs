using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml;       // xml class library


namespace Final
{   
    public partial class Form1 : Form
    {
        Players Winner = new Players();
        List <Label> lblPlayersLists = new List<Label>();
        int QuestionsAvailable = 0;
        int QuestionsAnswered = 0;
        int playerTurn = 0;
        int currentPlayer;
        public Form1()
        {
            #region Starting UP
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
            Application.Run(new frmOption());
            InitializeComponent();


            // Dynamicly create lalbel for Scoreboard
            int count = Players.PlayersArray.Count(s => s != null);
            if ( count == 0 )
            {
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Label lblPlayer = new Label();
                    lblPlayer.AutoSize = true;
                    lblPlayer.Location = new System.Drawing.Point(50, 18 + i * 22);
                    lblPlayer.Size = new System.Drawing.Size(42, 13);
                    lblPlayer.TabIndex = 7;
                    lblPlayer.ForeColor = Color.Gold;
                    lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    lblPlayer.Text = $"{Players.PlayersArray[i].PlayerName}: ${Players.PlayersArray[i].Score.ToString()}";
                    lblPlayersLists.Add(lblPlayer);
                    this.panel1.Controls.Add(lblPlayer);
                }// End of for
                 // Get the first current player Showed
                lblCurrentPlayer.Text = Players.PlayersArray[playerTurn].ToString();
            }

            #endregion
            #region Create Categories and Questions Buttons
            int initY = 100;
            int initX = 50;
            CategoryButton aCategoryButton = new CategoryButton();
            for (int i = 0; i < 5; i++)
            {
                int x = initX + i * 148;
                int y = initY;
                // Add category
                var aCategory = new Category();
                aCategory.Location = new System.Drawing.Point(x, y);
                aCategory.Margin = new System.Windows.Forms.Padding(4);
                aCategory.Text = "" + i;
                aCategory.Size = new System.Drawing.Size(140, 31);
                //aCategory.Enabled = false;
                aCategory.ForeColor = Color.White;
                aCategory.BackColor = Color.DarkBlue;
                this.Controls.Add(aCategory);
                for (int j = 1; j < 6; j++) // if j = 0 then the y cordinate will be exactly at the category button 
                {
                    // Add question
                    QuestionsAvailable++;
                    y = initY + j * 65;
                    var aQuestion = new Question();
                    aQuestion.Location = new System.Drawing.Point(x, y);
                    aQuestion.Margin = new System.Windows.Forms.Padding(4);
                    aQuestion.Text = "" + i;
                    aQuestion.Size = new System.Drawing.Size(140, 50);
                    aQuestion.ForeColor = Color.Yellow;
                    aQuestion.Font = new Font(aQuestion.Font, FontStyle.Bold);
                    aQuestion.Click += new EventHandler(Button_Click);
                    aQuestion.FlatAppearance.BorderColor = Color.DarkBlue;
                    this.Controls.Add(aQuestion);
                    aCategory.Questions.Add(aQuestion);
                }
                aCategoryButton.Categories.Add(aCategory);
            }
            Console.WriteLine("Available Questions: {0}",QuestionsAvailable);
            #endregion
            #region Testing
            //Console.WriteLine("Testomg");
            //for (int i =0; i< aCategoryButton.Categories.Count; i++)
            //{
            //    var category = (Category)aCategoryButton.Categories[i];
            //    Console.WriteLine(category.Text);
            //    for (int j = 0; j < category.Questions.Count; j++)
            //    {
            //        var question = (Question)category.Questions[j];
            //        Console.WriteLine(question.Text);
            //    }
            //}
            #endregion
            #region Read XML file (Read Tags and Element Values) + Set the .Text for buttons
            XmlReader reader = XmlReader.Create("Jeopardy.xml");
            int k = 0;
            int l = 0;
            Category bCategory = new Category();
            Question bQuestion = new Question();
            while (reader.Read())
            {
                if (reader.HasAttributes) /// Read attributes
                {                 
                    //Console.WriteLine("Attributes of <" + reader.Name + ">");

                    for (int i = 0; i < reader.AttributeCount; i++)
                    {

                        reader.MoveToAttribute(i);
                       // Console.WriteLine(" {0}={1}   ", reader.Name, reader.Value);
                        if (reader.Name == "name")
                        {
                            bCategory = (Category)aCategoryButton.Categories[k];
                            bCategory.Text = reader.Value;
                            k++;
                        }
                        else if (reader.Name == "points")
                        {
                            if (l == 4)
                            {
                                bQuestion = (Question)bCategory.Questions[l];
                                //bQuestion.Text = reader.Value;
                                bQuestion.Point = Convert.ToInt32(reader.Value);
                                bQuestion.Text =$"${bQuestion.Point.ToString()}";

                            }
                            else
                            {
                                bQuestion = (Question)bCategory.Questions[l];
                                //bQuestion.Text = reader.Value;
                                bQuestion.Point = Convert.ToInt32(reader.Value);
                                bQuestion.Text = $"${bQuestion.Point.ToString()}";

                            }
                        }
                        else if (reader.Name == "answer")
                        {
                            if (l == 4)
                            {
                                bQuestion = (Question)bCategory.Questions[l];
                                bQuestion.Answer = reader.Value;
                                l = 0;
                            }
                            else
                            {
                                bQuestion = (Question)bCategory.Questions[l];
                                bQuestion.Answer = reader.Value;
                                l++;
                            }                     
                        }
                    }// Finish reading attribute
                    if (reader.IsStartElement()) // is this a tag
                    {
                        switch (reader.Name)    // check the name of this tag
                        {
                            case "first":
                                reader.Read();  // read again to get value
                                bQuestion.Trivia = reader.Value;
                                break;
                            case "second":
                                reader.Read();  // read again to get value
                                                //bQuestion = (Question)bCategory.Questions[1];
                                bQuestion.Trivia = reader.Value;
                                break;
                            case "third":
                                reader.Read();  // read again to get value
                                                //bQuestion = (Question)bCategory.Questions[2];
                                bQuestion.Trivia = reader.Value;
                                break;
                            case "fourth":
                                reader.Read();  // read again to get value
                                                //bQuestion = (Question)bCategory.Questions[3];
                                bQuestion.Trivia = reader.Value;
                                break;
                            case "fifth":
                                reader.Read();  // read again to get value
                                                //bQuestion = (Question)bCategory.Questions[4];
                                bQuestion.Trivia = reader.Value;
                                break;
                                // add more case logic for our other fields
                        }  // end of switch (for tag)

                    }  // End of if (reader.IsStartElement())

                }// END of if (reader.HasAttributes)

            }
            #endregion
            #region XmlReader Scratch
            //while (reader.Read())
            //{

            //    if (reader.IsStartElement()) // is this a tag
            //    {
            //        //aCategory = new Category();
            //        //aQuestion = new Question();
            //        if (reader.HasAttributes)
            //        {
            //            if (reader.Name == "name")
            //            {
            //                aCategory.CategoryName = reader.Value;
            //                for (int i = 0; i < reader.AttributeCount; i++)
            //                {
            //                    reader.MoveToAttribute(i);
            //                    aCategory.CategoryName = reader.Value;
            //                }
            //            }
            //            else
            //            {
            //                for (int i = 0; i < reader.AttributeCount; i++)
            //                {
            //                    reader.MoveToAttribute(i);


            //                }
            //            }
            //            Console.WriteLine("Attributes of <" + reader.Name + ">");
            //            for (int i = 0; i < reader.AttributeCount; i++)
            //            {
            //                reader.MoveToAttribute(i);
            //                Console.Write(" {0}={1}   ", reader.Name, reader.Value);
            //                Console.WriteLine();

            //            }
            //        }

            //    }  // end of if

            //} // end of while

            //Console.WriteLine("Tesing");
            //foreach (var item in aCategoryButton.Categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }// End of Form1 Method
        /// <summary>
        /// Purpose: Change players turn each time they answer a question
        /// </summary>
        private void PlayerChanging()
        {
            int count = Players.PlayersArray.Count(s => s != null);
            if (playerTurn == count - 1)
            {
                playerTurn = 0;
                lblCurrentPlayer.Text = Players.PlayersArray[playerTurn].ToString();
            }
            else
            {
                playerTurn++;
                lblCurrentPlayer.Text = Players.PlayersArray[playerTurn].ToString();
            }

        }
        /// <summary>
        /// Purpose: Run the SplashScreen
        /// </summary>
        public void StartForm()
        {
            Application.Run(new frmSplashScreen());
        }
        /// <summary>
        /// Scratch
        /// </summary>
       # region Scratch
        public void displayQuestions()
        {
            //int initY = 100;
            //int initX = 50;
            //int counter = 0;
            //Category aCategory = new Category();
            //Question aQuestion = new Question();
            //for (int i = 0; i < 30; i++)
            //{
            //    int x = initX + i / 6 * 148; 
            //    int y = initY + i % 6 * 65;
            //    if (y == initY)
            //    {
            //        aCategory = new Category();
            //        aCategory.Location = new System.Drawing.Point(x, y);
            //        aCategory.Margin = new System.Windows.Forms.Padding(4);
            //        aCategory.Text = "" + i;
            //        aCategory.Size = new System.Drawing.Size(140, 31);
            //        this.Controls.Add(aCategory);
            //        Category.Categories.Add(aCategory);
            //        counter++;


            //    }
            //    else
            //    {
            //        aQuestion = new Question();
            //        aQuestion.Location = new System.Drawing.Point(x, y);
            //        aQuestion.Margin = new System.Windows.Forms.Padding(4);
            //        aQuestion.Text = "" + i;
            //        aQuestion.Size = new System.Drawing.Size(140, 31);
            //        this.Controls.Add(aQuestion);    
            //        Category.Categories[counter - 1].Questions.Add(aQuestion);
            //    }
            //}

            
        }// END displayQuestions 
        #endregion
        /// <summary>
        /// Purpose: Fire the function when a button is clicked, pass them the question form the QuestionButton object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click(object sender, EventArgs e)
        {
            int point = 0;
            QuestionsAnswered++;
            bool val = false;          
            currentPlayer = playerTurn;
            Question b = (Question)sender;
            b.FlatAppearance.BorderColor = Color.DarkBlue;

            using (var form = new frmAandQ(b))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                     point = form.ReturnPoint;            //values preserved after close
                     val = form.ReturnBool;                   
                }
                ScoreBoardUpdate(point);
                Winner = GameChecking();

            }
            b.Enabled = false;
            PlayerChanging();
        }
        /// <summary>
        /// Purpose: Update the score board everytime a player answer or dont answer a question
        /// </summary>
        /// <param name="point"></param>
        public void ScoreBoardUpdate(int point)
        {
            Players.PlayersArray[playerTurn].Score += point;
            int count = Players.PlayersArray.Count(s => s != null);
            for (int i =0; i < count; i++)
            {
                Label aLabel = new Label();
                aLabel = lblPlayersLists[i];
                aLabel.Text = $"{Players.PlayersArray[i].PlayerName}: ${Players.PlayersArray[i].Score.ToString()}";
            }

        }
        /// <summary>
        /// Purpose:  Check for who has the highest score and print on the up left corner, 
        ///             Also declare the winner when every question is done
        /// </summary>
        /// <returns></returns>
        public Players GameChecking()
        {
            Players fstPlayer = new Players();
            fstPlayer.Score = -99999;
            int count = Players.PlayersArray.Count(s => s != null);
            for (int i = 0 ; i< count; i++ )
            {
                int temp;
                temp = Players.PlayersArray[i].Score;
                if (temp > fstPlayer.Score)
                {
                    fstPlayer.Score = temp;
                    fstPlayer.PlayerName = Players.PlayersArray[i].PlayerName;
                }


            }
            // If every question is chosen
            if (QuestionsAnswered == QuestionsAvailable)
            {
                MessageBox.Show($"The winner is: {fstPlayer.PlayerName} with ${fstPlayer.Score}");
                Serializer.SerializeNow($"The winner is: {fstPlayer.PlayerName} with ${fstPlayer.Score}"); // Serialize Data and Push to Database
                if (MessageBox.Show("Do you want to play another game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    this.Close();
                }
                
            }
            lblLeader.Text =$"{fstPlayer.PlayerName}: ${fstPlayer.Score} ";
            return fstPlayer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }// End FORM
}
