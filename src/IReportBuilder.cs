namespace BuilderChallenge;

public interface IReportBuilder
{
    IReportBuilder SetTitle(string title);
    IReportBuilder SetFormat(string format);
    IReportBuilder SetStartDate(DateTime startDate);
    IReportBuilder SetEndDate(DateTime endDate);
    IReportBuilder IncludeHeader(bool include, string? headerText = null);
    IReportBuilder IncludeFooter(bool include, string? footerText = null);
    IReportBuilder IncludeCharts(bool include, string? chartType = null);
    IReportBuilder IncludeSummary(bool include);
    IReportBuilder AddColumn(string column);
    IReportBuilder AddFilter(string filter);
    IReportBuilder SetSortBy(string sortBy);
    IReportBuilder SetGroupBy(string groupBy);
    IReportBuilder IncludeTotals(bool include);
    IReportBuilder SetOrientation(string orientation);
    IReportBuilder SetPageSize(string pageSize);
    IReportBuilder IncludePageNumbers(bool include);
    IReportBuilder SetCompanyLogo(string logoPath);
    IReportBuilder SetWaterMark(string waterMarkText);
    Report Build();
}