namespace CrossRiver
{
    public partial class Form1 : Form
    {
        private List<string> _personagensNoBarco = new();
        private List<string> _personagensLadoEsquerdo = new() { "Ladrao", "Policial", "Filho1", "Filho2", "Filha1", "Filha2", "Mae", "Pai" };
        private List<string> _personagensLadoDireito = new();

        private List<Panel> _personagens;
        private int _ladoBarco;

        public Form1()
        {
            InitializeComponent();

            _personagens = new List<Panel>()
            {
                Ladrao,
                Policial,
                Filho1,
                Filho2,
                Filha1,
                Filha2,
                Mae,
                Pai
            };

            Policial.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Policial); };
            Mae.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Mae); };
            Pai.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Pai); };
            Ladrao.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Ladrao); };
            Filho1.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Filho1); };
            Filho2.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Filho2); };
            Filha1.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Filha1); };
            Filha2.Click += delegate (object sender, EventArgs e) { AlterarSelecaoPersonagem(sender, e, Filha2); };
        }

        private void AlterarSelecaoPersonagem(object sender, EventArgs e, Panel personagem)
        {
            if (_personagensNoBarco.Any(x => x.Contains(personagem.Name)))
                RemoverDoBarco(personagem.Name);
            else
                AdicionarNoBarco(personagem.Name);
        }

        private void AdicionarNoBarco(string personagem)
        {
            if (_personagensNoBarco.Count == 2)
                return;

            if (_ladoBarco == 1)
                if (_personagensLadoEsquerdo.Contains(personagem))
                    return;

            if (_ladoBarco == 0)
                if (_personagensLadoDireito.Contains(personagem))
                    return;

            _personagensNoBarco.Add(personagem);

            MostrarPersonagensNoBarco(personagem);
        }

        private void RemoverDoBarco(string personagem)
        {
            _personagensNoBarco.Remove(personagem);

            MostrarPersonagensNoBarco(personagem);
        }

        private void MostrarPersonagensNoBarco(string personagem)
        {
            var txtTela = string.Empty;

            if (_personagensNoBarco.Count == 0)
                PrimeiroPassageiroBarco.Text = txtTela;
            else
            {
                foreach (var personagemBarco in _personagensNoBarco)
                {
                    txtTela += $"{personagemBarco}{Environment.NewLine}";
                }

                PrimeiroPassageiroBarco.Text = txtTela;
            }

        }

        private void BtnLadoEsquerdo_Click(object sender, EventArgs e)
        {
            if (!ValidarMotoristas())
            {
                MessageBox.Show("Motorista nao esta valida");
                return;
            }

            if (!ValidarMae(_personagensLadoEsquerdo) || !ValidarMae(_personagensLadoDireito))
            {
                MessageBox.Show("Mae nao esta valida");
                return;
            }

            if (!ValidarPai(_personagensLadoEsquerdo) || !ValidarPai(_personagensLadoDireito))
            {
                MessageBox.Show("Pai nao esta valido");
                return;
            }

            if (!ValidarLadrao(_personagensLadoEsquerdo) || !ValidarLadrao(_personagensLadoDireito))
            {
                MessageBox.Show("Ladrao nao esta valido");
                return;
            }

            PrimeiroPassageiroBarco.Text = string.Empty;
            _ladoBarco = 1;

            foreach (var personagem in _personagensNoBarco)
            {
                _personagensLadoEsquerdo.Remove(personagem);
                _personagensLadoDireito.Add(personagem);

                MoverPersonagemParaLadoDireito(personagem);
            }

            _personagensNoBarco.RemoveAll(x=>true);
        }

        private void BtnLadoDireito_Click(object sender, EventArgs e)
        {
            if (!ValidarMotoristas())
            {
                MessageBox.Show("Motorista nao esta valida");
                return;
            }

            if (!ValidarMae(_personagensLadoDireito) || !ValidarMae(_personagensLadoEsquerdo))
            {
                MessageBox.Show("Mae nao esta valida");
                return;
            }

            if (!ValidarPai(_personagensLadoDireito) || !ValidarPai(_personagensLadoEsquerdo))
            {
                MessageBox.Show("Pai nao esta valido");
                return;
            }

            if (!ValidarLadrao(_personagensLadoDireito) || !ValidarLadrao(_personagensLadoEsquerdo))
            {
                MessageBox.Show("Ladrao nao esta valido");
                return;
            }

            PrimeiroPassageiroBarco.Text = string.Empty;
            _ladoBarco = 0;

            foreach (var personagem in _personagensNoBarco)
            {
                _personagensLadoDireito.Remove(personagem);
                _personagensLadoEsquerdo.Add(personagem);

                MoverPersonagemParaLadoEsquerdo(personagem);
            }

            _personagensNoBarco.RemoveAll(x => true);
        }

        private void MoverPersonagemParaLadoEsquerdo(string personagem)
        {
            var panelPersonagem = _personagens.First(x => x.Name == personagem);

            var locX = panelPersonagem.Location.X - 900;
            var locY = panelPersonagem.Location.Y;

            panelPersonagem.Location = new Point(locX, locY);
        }

        private void MoverPersonagemParaLadoDireito(string personagem)
        {
            var panelPersonagem = _personagens.First(x=> x.Name == personagem);

            var locX = panelPersonagem.Location.X + 900;
            var locY = panelPersonagem.Location.Y;

            panelPersonagem.Location = new Point(locX, locY);
        }

        private bool ValidarMotoristas()
        {
            var motoristas = new string[] { "Pai", "Policial", "Mae"};

            if (!_personagensNoBarco.Intersect(motoristas).Any())
                return false;

            return true;
        }

        private bool ValidarLadrao(List<string> ladoLago)
        {
            var personagens = ladoLago;

            foreach (var item in _personagensNoBarco)
                personagens.Remove(item);

            if(personagens.Count == 1)
                if(personagens.First().Contains("Ladrao"))
                    return true;

            if(personagens.Contains("Ladrao") && !personagens.Contains("Policial"))
                return false;
            
            return true;
        }

        private bool ValidarPai(List<string> ladoLago)
        {
            var personagensFilhas = new string[] { "Filha1", "Filha2" };
            var personagensQuePodemFicarJuntos = new string[] { "Mae", "Policial" };

            var personagens = ladoLago;

            foreach (var item in _personagensNoBarco)
                if (ladoLago.Contains(item))
                    personagens.Remove(item);
                else
                    personagens.Add(item);

            if (personagens.Count == 1)
                if (personagens.First().Contains("Pai"))
                    return true;

            if (personagens.Contains("Pai") && ladoLago.Intersect(personagensFilhas).Any() && !ladoLago.Intersect(personagensQuePodemFicarJuntos).Any())
                return false;

            return true;
        }

        private bool ValidarMae(List<string> ladoLago)
        {
            var personagensFilhas = new string[] { "Filho1", "Filho2" };
            var personagensQuePodemFicarJuntos = new string[] { "Pai", "Policial" };

            var personagens = ladoLago;

            foreach (var item in _personagensNoBarco)
                if(ladoLago.Contains(item))
                    personagens.Remove(item);
                else
                    personagens.Add(item);

            if (personagens.Count == 1)
                if (personagens.First().Contains("Mae"))
                    return true;

            if (personagens.Contains("Mae") && ladoLago.Intersect(personagensFilhas).Any() && !ladoLago.Intersect(personagensQuePodemFicarJuntos).Any())
                return false;

            return true;
        }
    }
}