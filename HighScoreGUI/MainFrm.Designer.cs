namespace HighScoreGUI
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            textBox1=new TextBox();
            dtgPlayers=new DataGridView();
            playerIdDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            nicknameDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            playerViewModelBindingSource=new BindingSource(components);
            dtgGames=new DataGridView();
            gameIdDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            gameViewModelBindingSource=new BindingSource(components);
            dtgHighscoresPlayer=new DataGridView();
            gameIdDataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
            playerIdDataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            scoreDateDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            highScoreBindingSource=new BindingSource(components);
            dtgHighscoresGame=new DataGridView();
            dataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
            highScoreBindingSource1=new BindingSource(components);
            btnDetailsPlayer=new Button();
            btnAddPlayer=new Button();
            btnDeletePlayer=new Button();
            btnDeleteGame=new Button();
            btnAddGame=new Button();
            btnDetailsGame=new Button();
            btnDeleteHighscorePlayer=new Button();
            btnAddHighscorePlayer=new Button();
            btnDetailsHighscorePlayer=new Button();
            btnDeleteHighscoreGame=new Button();
            btnAddHighscoreGame=new Button();
            btnDetailsHighscoreGame=new Button();
            btnRollback=new Button();
            btnSave=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highScoreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highScoreBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location=new Point(1275, 12);
            textBox1.Multiline=true;
            textBox1.Name="textBox1";
            textBox1.Size=new Size(189, 488);
            textBox1.TabIndex=4;
            // 
            // dtgPlayers
            // 
            dtgPlayers.AutoGenerateColumns=false;
            dtgPlayers.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dtgPlayers.BackgroundColor=SystemColors.Control;
            dtgPlayers.BorderStyle=BorderStyle.None;
            dtgPlayers.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPlayers.Columns.AddRange(new DataGridViewColumn[] { playerIdDataGridViewTextBoxColumn, nicknameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dtgPlayers.DataSource=playerViewModelBindingSource;
            dtgPlayers.Location=new Point(12, 12);
            dtgPlayers.Name="dtgPlayers";
            dtgPlayers.RowHeadersWidth=51;
            dtgPlayers.RowTemplate.Height=29;
            dtgPlayers.Size=new Size(575, 268);
            dtgPlayers.TabIndex=5;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            playerIdDataGridViewTextBoxColumn.DataPropertyName="PlayerId";
            playerIdDataGridViewTextBoxColumn.HeaderText="PlayerId";
            playerIdDataGridViewTextBoxColumn.MinimumWidth=6;
            playerIdDataGridViewTextBoxColumn.Name="playerIdDataGridViewTextBoxColumn";
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            nicknameDataGridViewTextBoxColumn.DataPropertyName="Nickname";
            nicknameDataGridViewTextBoxColumn.HeaderText="Nickname";
            nicknameDataGridViewTextBoxColumn.MinimumWidth=6;
            nicknameDataGridViewTextBoxColumn.Name="nicknameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName="Email";
            emailDataGridViewTextBoxColumn.HeaderText="Email";
            emailDataGridViewTextBoxColumn.MinimumWidth=6;
            emailDataGridViewTextBoxColumn.Name="emailDataGridViewTextBoxColumn";
            // 
            // playerViewModelBindingSource
            // 
            playerViewModelBindingSource.DataSource=typeof(HighScoreModels.ViewModels.PlayerViewModel);
            // 
            // dtgGames
            // 
            dtgGames.AutoGenerateColumns=false;
            dtgGames.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dtgGames.BackgroundColor=SystemColors.Control;
            dtgGames.BorderStyle=BorderStyle.None;
            dtgGames.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGames.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn });
            dtgGames.DataSource=gameViewModelBindingSource;
            dtgGames.Location=new Point(648, 12);
            dtgGames.Name="dtgGames";
            dtgGames.RowHeadersWidth=51;
            dtgGames.RowTemplate.Height=29;
            dtgGames.Size=new Size(575, 268);
            dtgGames.TabIndex=6;
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            gameIdDataGridViewTextBoxColumn.DataPropertyName="GameId";
            gameIdDataGridViewTextBoxColumn.HeaderText="GameId";
            gameIdDataGridViewTextBoxColumn.MinimumWidth=6;
            gameIdDataGridViewTextBoxColumn.Name="gameIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName="Title";
            titleDataGridViewTextBoxColumn.HeaderText="Title";
            titleDataGridViewTextBoxColumn.MinimumWidth=6;
            titleDataGridViewTextBoxColumn.Name="titleDataGridViewTextBoxColumn";
            // 
            // gameViewModelBindingSource
            // 
            gameViewModelBindingSource.DataSource=typeof(HighScoreModels.ViewModels.GameViewModel);
            // 
            // dtgHighscoresPlayer
            // 
            dtgHighscoresPlayer.AutoGenerateColumns=false;
            dtgHighscoresPlayer.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dtgHighscoresPlayer.BackgroundColor=SystemColors.Control;
            dtgHighscoresPlayer.BorderStyle=BorderStyle.None;
            dtgHighscoresPlayer.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHighscoresPlayer.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn1, playerIdDataGridViewTextBoxColumn1, scoreDataGridViewTextBoxColumn, scoreDateDataGridViewTextBoxColumn });
            dtgHighscoresPlayer.DataSource=highScoreBindingSource;
            dtgHighscoresPlayer.Location=new Point(12, 366);
            dtgHighscoresPlayer.Name="dtgHighscoresPlayer";
            dtgHighscoresPlayer.RowHeadersWidth=51;
            dtgHighscoresPlayer.RowTemplate.Height=29;
            dtgHighscoresPlayer.Size=new Size(575, 243);
            dtgHighscoresPlayer.TabIndex=7;
            // 
            // gameIdDataGridViewTextBoxColumn1
            // 
            gameIdDataGridViewTextBoxColumn1.DataPropertyName="GameId";
            gameIdDataGridViewTextBoxColumn1.HeaderText="GameId";
            gameIdDataGridViewTextBoxColumn1.MinimumWidth=6;
            gameIdDataGridViewTextBoxColumn1.Name="gameIdDataGridViewTextBoxColumn1";
            // 
            // playerIdDataGridViewTextBoxColumn1
            // 
            playerIdDataGridViewTextBoxColumn1.DataPropertyName="PlayerId";
            playerIdDataGridViewTextBoxColumn1.HeaderText="PlayerId";
            playerIdDataGridViewTextBoxColumn1.MinimumWidth=6;
            playerIdDataGridViewTextBoxColumn1.Name="playerIdDataGridViewTextBoxColumn1";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName="Score";
            scoreDataGridViewTextBoxColumn.HeaderText="Score";
            scoreDataGridViewTextBoxColumn.MinimumWidth=6;
            scoreDataGridViewTextBoxColumn.Name="scoreDataGridViewTextBoxColumn";
            // 
            // scoreDateDataGridViewTextBoxColumn
            // 
            scoreDateDataGridViewTextBoxColumn.DataPropertyName="ScoreDate";
            scoreDateDataGridViewTextBoxColumn.HeaderText="ScoreDate";
            scoreDateDataGridViewTextBoxColumn.MinimumWidth=6;
            scoreDateDataGridViewTextBoxColumn.Name="scoreDateDataGridViewTextBoxColumn";
            // 
            // highScoreBindingSource
            // 
            highScoreBindingSource.DataSource=typeof(HighScoreModels.HighScore);
            // 
            // dtgHighscoresGame
            // 
            dtgHighscoresGame.AutoGenerateColumns=false;
            dtgHighscoresGame.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dtgHighscoresGame.BackgroundColor=SystemColors.Control;
            dtgHighscoresGame.BorderStyle=BorderStyle.None;
            dtgHighscoresGame.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHighscoresGame.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dtgHighscoresGame.DataSource=highScoreBindingSource1;
            dtgHighscoresGame.Location=new Point(648, 366);
            dtgHighscoresGame.Name="dtgHighscoresGame";
            dtgHighscoresGame.RowHeadersWidth=51;
            dtgHighscoresGame.RowTemplate.Height=29;
            dtgHighscoresGame.Size=new Size(575, 243);
            dtgHighscoresGame.TabIndex=8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName="GameId";
            dataGridViewTextBoxColumn1.HeaderText="GameId";
            dataGridViewTextBoxColumn1.MinimumWidth=6;
            dataGridViewTextBoxColumn1.Name="dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName="PlayerId";
            dataGridViewTextBoxColumn2.HeaderText="PlayerId";
            dataGridViewTextBoxColumn2.MinimumWidth=6;
            dataGridViewTextBoxColumn2.Name="dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName="Score";
            dataGridViewTextBoxColumn3.HeaderText="Score";
            dataGridViewTextBoxColumn3.MinimumWidth=6;
            dataGridViewTextBoxColumn3.Name="dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName="ScoreDate";
            dataGridViewTextBoxColumn4.HeaderText="ScoreDate";
            dataGridViewTextBoxColumn4.MinimumWidth=6;
            dataGridViewTextBoxColumn4.Name="dataGridViewTextBoxColumn4";
            // 
            // highScoreBindingSource1
            // 
            highScoreBindingSource1.DataSource=typeof(HighScoreModels.HighScore);
            // 
            // btnDetailsPlayer
            // 
            btnDetailsPlayer.Location=new Point(12, 286);
            btnDetailsPlayer.Name="btnDetailsPlayer";
            btnDetailsPlayer.Size=new Size(94, 29);
            btnDetailsPlayer.TabIndex=9;
            btnDetailsPlayer.Text="Details";
            btnDetailsPlayer.UseVisualStyleBackColor=true;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location=new Point(373, 286);
            btnAddPlayer.Name="btnAddPlayer";
            btnAddPlayer.Size=new Size(94, 29);
            btnAddPlayer.TabIndex=10;
            btnAddPlayer.Text="Add";
            btnAddPlayer.UseVisualStyleBackColor=true;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.Location=new Point(473, 286);
            btnDeletePlayer.Name="btnDeletePlayer";
            btnDeletePlayer.Size=new Size(94, 29);
            btnDeletePlayer.TabIndex=11;
            btnDeletePlayer.Text="Delete";
            btnDeletePlayer.UseVisualStyleBackColor=true;
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Location=new Point(1109, 286);
            btnDeleteGame.Name="btnDeleteGame";
            btnDeleteGame.Size=new Size(94, 29);
            btnDeleteGame.TabIndex=14;
            btnDeleteGame.Text="Delete";
            btnDeleteGame.UseVisualStyleBackColor=true;
            // 
            // btnAddGame
            // 
            btnAddGame.Location=new Point(1009, 286);
            btnAddGame.Name="btnAddGame";
            btnAddGame.Size=new Size(94, 29);
            btnAddGame.TabIndex=13;
            btnAddGame.Text="Add";
            btnAddGame.UseVisualStyleBackColor=true;
            // 
            // btnDetailsGame
            // 
            btnDetailsGame.Location=new Point(648, 286);
            btnDetailsGame.Name="btnDetailsGame";
            btnDetailsGame.Size=new Size(94, 29);
            btnDetailsGame.TabIndex=12;
            btnDetailsGame.Text="Details";
            btnDetailsGame.UseVisualStyleBackColor=true;
            // 
            // btnDeleteHighscorePlayer
            // 
            btnDeleteHighscorePlayer.Location=new Point(493, 615);
            btnDeleteHighscorePlayer.Name="btnDeleteHighscorePlayer";
            btnDeleteHighscorePlayer.Size=new Size(94, 29);
            btnDeleteHighscorePlayer.TabIndex=17;
            btnDeleteHighscorePlayer.Text="Delete";
            btnDeleteHighscorePlayer.UseVisualStyleBackColor=true;
            // 
            // btnAddHighscorePlayer
            // 
            btnAddHighscorePlayer.Location=new Point(393, 615);
            btnAddHighscorePlayer.Name="btnAddHighscorePlayer";
            btnAddHighscorePlayer.Size=new Size(94, 29);
            btnAddHighscorePlayer.TabIndex=16;
            btnAddHighscorePlayer.Text="Add";
            btnAddHighscorePlayer.UseVisualStyleBackColor=true;
            // 
            // btnDetailsHighscorePlayer
            // 
            btnDetailsHighscorePlayer.Location=new Point(12, 615);
            btnDetailsHighscorePlayer.Name="btnDetailsHighscorePlayer";
            btnDetailsHighscorePlayer.Size=new Size(94, 29);
            btnDetailsHighscorePlayer.TabIndex=15;
            btnDetailsHighscorePlayer.Text="Details";
            btnDetailsHighscorePlayer.UseVisualStyleBackColor=true;
            // 
            // btnDeleteHighscoreGame
            // 
            btnDeleteHighscoreGame.Location=new Point(1129, 615);
            btnDeleteHighscoreGame.Name="btnDeleteHighscoreGame";
            btnDeleteHighscoreGame.Size=new Size(94, 29);
            btnDeleteHighscoreGame.TabIndex=20;
            btnDeleteHighscoreGame.Text="Delete";
            btnDeleteHighscoreGame.UseVisualStyleBackColor=true;
            // 
            // btnAddHighscoreGame
            // 
            btnAddHighscoreGame.Location=new Point(1029, 615);
            btnAddHighscoreGame.Name="btnAddHighscoreGame";
            btnAddHighscoreGame.Size=new Size(94, 29);
            btnAddHighscoreGame.TabIndex=19;
            btnAddHighscoreGame.Text="Add";
            btnAddHighscoreGame.UseVisualStyleBackColor=true;
            // 
            // btnDetailsHighscoreGame
            // 
            btnDetailsHighscoreGame.Location=new Point(648, 615);
            btnDetailsHighscoreGame.Name="btnDetailsHighscoreGame";
            btnDetailsHighscoreGame.Size=new Size(94, 29);
            btnDetailsHighscoreGame.TabIndex=18;
            btnDetailsHighscoreGame.Text="Details";
            btnDetailsHighscoreGame.UseVisualStyleBackColor=true;
            // 
            // btnRollback
            // 
            btnRollback.Location=new Point(1275, 506);
            btnRollback.Name="btnRollback";
            btnRollback.Size=new Size(185, 66);
            btnRollback.TabIndex=21;
            btnRollback.Text="Rollback";
            btnRollback.UseVisualStyleBackColor=true;
            // 
            // btnSave
            // 
            btnSave.Location=new Point(1275, 578);
            btnSave.Name="btnSave";
            btnSave.Size=new Size(189, 66);
            btnSave.TabIndex=22;
            btnSave.Text="Save";
            btnSave.UseVisualStyleBackColor=true;
            // 
            // MainFrm
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1476, 656);
            Controls.Add(btnSave);
            Controls.Add(btnRollback);
            Controls.Add(btnDeleteHighscoreGame);
            Controls.Add(btnAddHighscoreGame);
            Controls.Add(btnDetailsHighscoreGame);
            Controls.Add(btnDeleteHighscorePlayer);
            Controls.Add(btnAddHighscorePlayer);
            Controls.Add(btnDetailsHighscorePlayer);
            Controls.Add(btnDeleteGame);
            Controls.Add(btnAddGame);
            Controls.Add(btnDetailsGame);
            Controls.Add(btnDeletePlayer);
            Controls.Add(btnAddPlayer);
            Controls.Add(btnDetailsPlayer);
            Controls.Add(dtgHighscoresGame);
            Controls.Add(dtgHighscoresPlayer);
            Controls.Add(dtgGames);
            Controls.Add(dtgPlayers);
            Controls.Add(textBox1);
            Name="MainFrm";
            Text="Highscores";
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)highScoreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)highScoreBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dtgPlayers;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource playerViewModelBindingSource;
        private DataGridView dtgGames;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private BindingSource gameViewModelBindingSource;
        private DataGridView dtgHighscoresPlayer;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDateDataGridViewTextBoxColumn;
        private BindingSource highScoreBindingSource;
        private DataGridView dtgHighscoresGame;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource highScoreBindingSource1;
        private Button btnDetailsPlayer;
        private Button btnAddPlayer;
        private Button btnDeletePlayer;
        private Button btnDeleteGame;
        private Button btnAddGame;
        private Button btnDetailsGame;
        private Button btnDeleteHighscorePlayer;
        private Button btnAddHighscorePlayer;
        private Button btnDetailsHighscorePlayer;
        private Button btnDeleteHighscoreGame;
        private Button btnAddHighscoreGame;
        private Button btnDetailsHighscoreGame;
        private Button btnRollback;
        private Button btnSave;
    }
}