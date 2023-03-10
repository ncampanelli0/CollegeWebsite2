using Radzen;

namespace CollegeWebsite2.Functionality;
public class Notify
{
    public NotificationMessage NotificationInfo(string summary, string detail, int duration)
    {
        return new NotificationMessage()
        {
            Severity = NotificationSeverity.Info,
            Summary = summary,
            Detail = detail,
            Duration = duration
        };
    }

    public NotificationMessage NotificationWarning(string summary, string detail, int duration)
    {
        return new NotificationMessage()
        {
            Severity = NotificationSeverity.Warning,
            Summary = summary,
            Detail = detail,
            Duration = duration
        };
    }

    public NotificationMessage NotificationError(string summary, string detail, int duration)
    {
        return new NotificationMessage()
        {
            Severity = NotificationSeverity.Error,
            Summary = summary,
            Detail = detail,
            Duration = duration
        };
    }

    public NotificationMessage NotificationSuccess(string summary, string detail, int duration)
    {
        return new NotificationMessage()
        {
            Severity = NotificationSeverity.Success,
            Summary = summary,
            Detail = detail,
            Duration = duration
        };
    }
}
