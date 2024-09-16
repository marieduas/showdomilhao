namespace showdomilhao;
public class questao
{
    public string Pergunta;
    public string Resposta0;
    public string resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public int Respostascorreta;
    public int nivelpergunta;
    private Button btnResposta0;
    private Button btnResposta1;
    private Button btnResposta2;
    private Button btnResposta3;
    private Button btnResposta4;
    private Label labelPergunta;

}
    public questao()
    {

    }
     public questao(Label Pergunta,Button button0,Button button1,Button button2,Button button3,Button button4)
    {
        labelPergunta = Pergunta;
        btnResposta0 = button0;
        btnResposta1 = button1;
        btnResposta2 = button2;
        btnResposta3 = button3;
        btnResposta4 = button4;
    }
    public void Desenhar()
    {
        labelPergunta.Text = Pergunta;
        btnResposta0.Text = button0;
        btnResposta1.Text = button1;
        btnResposta2.Text = button2;
        btnResposta3.Text = button3;
        btnResposta4.Text = button4;
    }
    public void configurardesenho (Label Pergunta,Button button0,Button button1,Button button2,Button button3,Button button4)
    {
        labelPergunta = Pergunta;
        btnResposta0 = button0;
        btnResposta1 = button1;
        btnResposta2 = button2;
        btnResposta3 = button3;
        btnResposta4 = button4;
    }
    public bool verificaaresposta(int Respostarespondida)
    {
            if (Respostarespondida == Respostascorreta)
            {
                var bnt= qualbnt(RR);
                bnt bacroudColor.Color Green
                return true;
            }
            else 
            {
                return false;
            }

            Privat Button qualbnt(int Respondido)
            
                
            
        
    }
    