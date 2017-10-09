
namespace PluginInterface
{
    public interface IPluginContext
    {
        IData Data { get; set; }
        IFigureView ActiveFigure { get; set; }
        IPlugin Plugin { get; }
    }
}
