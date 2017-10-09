using SimpleFigure.Figure.Control;

namespace SimpleFigurePlugin.Command
{
    public class Command
    {
        public SimpleFigureActions.ActionChangeColor ChangeColor;
        public SimpleFigureActions.ActionChangeType ChangeType;
        public SimpleFigureActions.ActionChangeWidth ChangeWidth;

        public Data Data { get; set; }
        public static FigureControl ActiveFigure { get; set; }

        public Command()
        {
            ChangeColor = new SimpleFigureActions.ActionChangeColor(this);
            ChangeType = new SimpleFigureActions.ActionChangeType(this);
            ChangeWidth = new SimpleFigureActions.ActionChangeWidth(this);
        }
    }
}
