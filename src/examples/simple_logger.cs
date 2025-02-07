using System.Diagnostics.CodeAnalysis;
enum LogLevel {
    Debug, Info, Warn, Error, Fatal
}
class Logger {
    private readonly string DEBUG_PREFIX;
    private readonly string INFO_PREFIX;
    private readonly string WARNING_PREFIX;
    private readonly string ERROR_PREFIX;
    private readonly string FATAL_PREFIX;

    // static member variables are like class specific variables rather than object specific.
    // for example logger_count, every instance of Logger can access it and modify it.
    private static int logger_count = 0;
    public Logger(String FATAL_PREFIX, String ERROR_PREFIX, String WARNING_PREFIX, String? INFO_PREFIX = null, String? DEBUG_PREFIX = null) {
        this.FATAL_PREFIX = FATAL_PREFIX;
        this.ERROR_PREFIX = ERROR_PREFIX;
        this.WARNING_PREFIX = WARNING_PREFIX;
        this.INFO_PREFIX = INFO_PREFIX == null? "" : INFO_PREFIX;
        this.DEBUG_PREFIX = DEBUG_PREFIX == null? "" : DEBUG_PREFIX;
        logger_count++;
    }

    public Logger() {
        DEBUG_PREFIX = "DEBUG: ";
        INFO_PREFIX = "";
        WARNING_PREFIX = "WARNING: ";
        ERROR_PREFIX = "ERROR: ";
        FATAL_PREFIX = "FATAL: ";
        logger_count++;
    }

    public void logFatal(String message) {
        Console.Error.WriteLine(FATAL_PREFIX+message);
    }

    public void logError(String message) {
        Console.Error.WriteLine(ERROR_PREFIX+message);
    }

    public void logWarning(String message) {
        Console.WriteLine(WARNING_PREFIX+message);
    }

    public void logInfo(String message) {
        Console.WriteLine(INFO_PREFIX+message);
    }

    public void logDebug(String message) {
        Console.WriteLine(DEBUG_PREFIX+message);
    }

    public void log(String message, LogLevel level) {
        switch (level) {
            case LogLevel.Debug:
                Console.WriteLine(DEBUG_PREFIX+message);
                break;
            case LogLevel.Info:
                Console.WriteLine(INFO_PREFIX+message);
                break;
            case LogLevel.Warn:
                Console.WriteLine(WARNING_PREFIX+message);
                break;
            case LogLevel.Error:
                Console.WriteLine(ERROR_PREFIX+message);
                break;
            case LogLevel.Fatal:
                Console.WriteLine(FATAL_PREFIX+message);
                break;
        }
    }

    public static int getLoggerCount() {
        return logger_count;
    }
}