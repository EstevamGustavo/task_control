using System.ComponentModel;

namespace tarefas_00.Enums
{
    public enum StatusTask
    {
        [Description("A Fazer")]
        wait = 1,
        [Description("Em Andamento")]
        doing = 2,
        [Description("Concluida")]
        conclude = 3,
        [Description("Cancelada")]
        canceled = 4,
        [Description("Deletada")]
        deleted = 5

    }
}
