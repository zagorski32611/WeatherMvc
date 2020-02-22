-- Drop '[time]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [time]
GO

-- Add a new column '[time]' to table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    ADD [time] /*new_column_name*/ bigint /*new_column_datatype*/ NULL /*new_column_nullability*/
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [sunriseTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [sunriseTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [sunsetTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [sunsetTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [TemperatureHighTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [TemperatureHighTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [TemperatureLowTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [TemperatureLowTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [windGustTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [windGustTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [uvIndexTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [uvIndexTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [TemperatureMinTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [TemperatureMinTime] bigint null
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [TemperatureMaxTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [TemperatureMaxTime] bigint null
GO


-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [apparentTemperatureMaxTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [apparentTemperatureMaxTime] bigint null
GO


-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    DROP COLUMN [apparentTemperatureMinTime]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[DailyData]
    add [apparentTemperatureMinTime] bigint null
GO


-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[HourlyData]
    DROP COLUMN [time]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[HourlyData]
    add [time] bigint null
GO


-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[MinutelyData]
    DROP COLUMN [time]
GO

-- Drop '[sunriseTime]' from table '[DailyData]' in schema '[dbo]'
ALTER TABLE [dbo].[MinutelyData]
    add [time] bigint null
GO
