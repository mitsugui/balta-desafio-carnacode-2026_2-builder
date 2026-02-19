namespace BuilderChallenge;


public class ReportBuilder : IReportBuilder
{
    private readonly Report _report;

    public ReportBuilder()
    {
        _report = new Report();
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public IReportBuilder SetFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public IReportBuilder SetStartDate(DateTime startDate)
    {
        _report.StartDate = startDate;
        return this;
    }

    public IReportBuilder SetEndDate(DateTime endDate)
    {
        _report.EndDate = endDate;
        return this;
    }

    public IReportBuilder IncludeHeader(bool include, string? headerText = null)
    {
        _report.IncludeHeader = include;
        if (include && headerText != null)
            _report.HeaderText = headerText;
        return this;
    }

    public IReportBuilder IncludeFooter(bool include, string? footerText = null)
    {
        _report.IncludeFooter = include;
        if (include && footerText != null)
            _report.FooterText = footerText;
        return this;
    }

    public IReportBuilder IncludeCharts(bool include, string? chartType = null)
    {
        _report.IncludeCharts = include;
        if (include && chartType != null)
            _report.ChartType = chartType;
        return this;
    }

    public IReportBuilder IncludeSummary(bool include)
    {
        _report.IncludeSummary = include;
        return this;
    }

    public IReportBuilder AddColumn(string column)
    {
        _report.Columns.Add(column);
        return this;
    }

    public IReportBuilder AddFilter(string filter)
    {
        _report.Filters.Add(filter);
        return this;
    }

    public IReportBuilder SetSortBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public IReportBuilder SetGroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public IReportBuilder IncludeTotals(bool include)
    {
        _report.IncludeTotals = include;
        return this;
    }

    public IReportBuilder SetOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public IReportBuilder SetPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public IReportBuilder IncludePageNumbers(bool include)
    {
        _report.IncludePageNumbers = include;
        return this;
    }

    public IReportBuilder SetCompanyLogo(string logoPath)
    {
        _report.CompanyLogo = logoPath;
        return this;
    }

    public IReportBuilder SetWaterMark(string waterMarkText)
    {
        _report.WaterMark = waterMarkText;
        return this;
    }

    public Report Build()
    {
        return _report;
    }
}