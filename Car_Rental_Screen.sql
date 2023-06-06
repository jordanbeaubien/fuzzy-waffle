/*
Pseudo-Query:
(((filter out all rentals from date > desired to date
group by VIN, find rental with highest from date) as T1
filter T1 by everything by a to date < desired from date) as T2
filter T2 where rental branch != desired branch from) as T3
list all types from T3 to choose from include price estimate (store all of the columns in a variable)
*/

--Car Rental Screen Query:
SELECT distinct T3.type FROM T3
EXCEPT
	(SELECT T3.* FROM T2
	WHERE T2.branch_id != pickup_location_combo.Text) as T3
		EXCEPT
		(SELECT T2.* FROM T1
		WHERE T2.to_date < pickup_date_picker.Value.ToString(yyyy-mm-dd)) as T2
			EXCEPT
			(SELECT R1.*, max(T1.from_date) as max_from_date FROM Rental as R1
			WHERE R1.from_date > dropoff_date_picker.Value.ToString(yyyy-mm-dd)
			GROUP BY vin) as T1