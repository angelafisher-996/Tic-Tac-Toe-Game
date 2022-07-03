# Tic-Tac-Toe

Овој проект се однесува на имплементација на играта Tic-Tac-Toe или Икс-Нула.

Дизајнот на оваа игра пред и по играње на истата:
![Tic-Tac-Toe](https://i.postimg.cc/3xympzmT/tic1.png)
![Tic-Tac-Toe](https://i.postimg.cc/prpX4M2V/tic2.png)

Како прв чекор се креира дизајнот на играта Tic-Tac-Toe со помош на drag and drop на компонентите од Toolbox-от во Visual Studio. Во овој случај се користени копчиња
и панели.
Потоа се иницијализираат полињата како глобални променливи 
```
 int scoreX = 0;
        int scoreO = 0;
        bool xTurn = true;
        bool OTurn = false;
```
каде што означуваме дека прв потег има играч Х и дека на почеток имаат двајцата играчи 0 поени.

Секое поле од таблата за играње Tic-Tac-Toe претставува копче односно button компонента со која што се работи преку click методот на секој button.

За таа цел најпрво се креираат две фунцкии со цел да се провери дали играчот Х или О победил при што доколку копчињата имаат иста вредност по дијагонална, хоризонтално и вертикално, тоа значи дека има победник.

```
 public bool checkWinnerX()
        {
            
           
            if(btn00.Text == "X" && btn11.Text=="X" && btn22.Text == "X")
            {
                btn00.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn00.Text == "X" && btn01.Text == "X" && btn02.Text == "X")
            {
                btn00.BackColor = Color.Red;
                btn01.BackColor = Color.Red;
                btn02.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;
            }
            if (btn00.Text == "X" && btn10.Text == "X" && btn20.Text == "X")
            {
                btn00.BackColor = Color.Red;
                btn10.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                btn20.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                btn10.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn02.Text == "X" && btn12.Text == "X" && btn22.Text == "X")
            {
                btn02.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn01.Text == "X" && btn11.Text == "X" && btn21.Text == "X")
            {
                btn01.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn02.Text == "X" && btn11.Text == "X" && btn20.Text == "X")
            {
                btn02.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            return false;

        }
        
        
```

и аналогно функција за O.

```
public bool checkWinnerO()
        {
           

            if (btn00.Text == "O" && btn11.Text == "O" && btn22.Text == "O")
            {
                btn00.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn00.Text == "O" && btn01.Text == "O" && btn02.Text == "O")
            {
                btn00.BackColor = Color.Red;
                btn01.BackColor = Color.Red;
                btn02.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn00.Text == "O" && btn10.Text == "O" && btn20.Text == "O")
            {
                btn00.BackColor = Color.Red;
                btn10.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;
            }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                btn20.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                btn10.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn02.Text == "O" && btn12.Text == "O" && btn22.Text == "O")
            {
                btn02.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;
                

            }
            if (btn01.Text == "O" && btn11.Text == "O" && btn21.Text == "O")
            {
                btn01.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;
            }
            if (btn02.Text == "O" && btn11.Text == "O" && btn20.Text == "O")
            {
                btn02.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            return false;
        }
```
Потоа на клик методите на секое копче се пишува следниот код:

```
 private void btn00_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn00.Text = "X";
                xTurn = false;
                OTurn = true;
                btn00.Enabled = false;
            }
            else if(OTurn)
            {
                btn00.Text = "O";
                OTurn = false;
                xTurn = true;
                btn00.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();
        }
```

каде што доколку е кликнато полето запишуваме Х или О зависно кој потег е на ред при што доколку е ред на Х, а тој е секогаш оној играч кој ја започнува играта, тогаш  ОTurn параметарот го поставуваме на true, а XTurn на false, бидејќи започнува потегот на играчот О, а доколку е редот на играч О, тогаш го поставуваме XTurn на true, а OTurn na false бидејќи следниот чекор ќе биде ред на играч Х. 
Тоа го правиме за сите полиња односно копчиња во играта.
На крајот ги повикуваме функциите за проверка на победа.

Потоа копчето Start New Game го имплементираме со методот:
```
private void btnNewGame_Click(object sender, EventArgs e)
        {
            reset();
            lbScoreO.Text = "0";
            lbScoreX.Text = "0";
        }
```
каде што го повикуваме reset() метоот кој има за цел да ја ресетира таблата, a овде додатно и го ресетираме score-ot.

```
 public void reset()
        {
            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            

            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;

            btn00.BackColor = Color.Gray;
            btn01.BackColor = Color.Gray;
            btn02.BackColor = Color.Gray;
            btn10.BackColor = Color.Gray;
            btn11.BackColor = Color.Gray;
            btn12.BackColor = Color.Gray;
            btn20.BackColor = Color.Gray;
            btn21.BackColor = Color.Gray;
            btn22.BackColor = Color.Gray;

            xTurn = true;
            OTurn = false;


        }
```

Исто така играта има и копче Exit Game каде што можеме да ја напуштиме играта доколку го сакаме тоа, имплементирано со клик методот на копчето Exit Game:
```
 private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Do you want to exit this game?", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

```
