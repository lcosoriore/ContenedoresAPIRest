CREATE DEFINER=`root`@`%` PROCEDURE `GetStatistics`(
)
BEGIN
SELECT `Statistics`.`budgetused`,
    `Statistics`.`containersdispatched`,
    `Statistics`.`containersnotdispatched`
FROM `Containers`.`Statistics`;
END