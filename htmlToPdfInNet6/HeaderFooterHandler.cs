using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

public class HeaderFooterHandler : IEventHandler
{
    public void HandleEvent(Event e)
    {
        PdfDocumentEvent docEvent = (PdfDocumentEvent)e;
        PdfDocument pdfDoc = docEvent.GetDocument();
        PdfPage page = docEvent.GetPage();

        Rectangle pageSize = page.GetPageSize();
        float yPosition = pageSize.GetTop() - 20;

        PdfCanvas canvas = new PdfCanvas(page.NewContentStreamBefore(), page.GetResources(), pdfDoc);
        new Canvas(canvas, pageSize)
            .ShowTextAligned("Header Text", pageSize.GetWidth() / 2, yPosition, TextAlignment.CENTER);

        canvas = new PdfCanvas(page.NewContentStreamAfter(), page.GetResources(), pdfDoc);
        new Canvas(canvas, pageSize)
            .ShowTextAligned("Footer Text", pageSize.GetWidth() / 2, 20, TextAlignment.CENTER);
    }
}
