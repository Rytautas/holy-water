INSERT INTO Drinks
                         (Bar_Id, Date_time, Glass_volume, Fill_percentage)
VALUES        (@Bar_Id,@Date_time,@Glass_volume,@Fill_percentage);
UPDATE Bars SET 
Total_average = ((Total_average * Total_count) + @Fill_percentage) / (Total_count + 1),
Total_count = Total_count + 1
WHERE Id = @Bar_Id;
SELECT Id, Bar_Id, Date_time, Glass_volume, Fill_percentage FROM Drinks WHERE (Id = SCOPE_IDENTITY())