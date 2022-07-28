namespace MovisisTecnologia.Domain.ViewModels;

    public class ResponseViewModel
    {
        public ResponseViewModel(int i, string m, object d)
        {
            Sucesso = i;
            Mensagem = m;
            Data = d;
        }
        public int Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Data { get; set; }
    }

    public class ResponseViewModel<T>
    {
        public ResponseViewModel(int i, string m, T d)
        {
            Sucesso = i;
            Mensagem = m;
            Data = d;
        }

        public int Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Data { get; set; }
    }
