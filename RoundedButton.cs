using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int CornerRadius { get; set; } = 10;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (GraphicsPath path = new GraphicsPath())
        {
            int width = this.Width;
            int height = this.Height;
            int cornerRadius = CornerRadius;

            path.StartFigure();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddLine(cornerRadius, 0, width - cornerRadius, 0);
            path.AddArc(width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddLine(width, cornerRadius, width, height - cornerRadius);
            path.AddArc(width - cornerRadius * 2, height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddLine(width - cornerRadius, height, cornerRadius, height);
            path.AddArc(0, height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
