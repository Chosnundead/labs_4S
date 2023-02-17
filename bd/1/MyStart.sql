--??? ??????
--UNIQ, FOREING KEY, PRIMARY KEY, CHECK, NOT NULL
--????? ??????? ????????? ?????
--INSERT ALL
--INTO TABLE_NAME(ID, DD) VALUES(1, 2)
--INTO TABLE_NAME(ID, DD) VALUES(1, 2)
--INTO TABLE_NAME(ID, DD) VALUES(1, 2)
--SELECT * FROM DUAL;
--??????????? ?????????? dml ??????????
--?? ??? ????? ??????? ?? ??? ????? ????????? COMMIT
--????????? ??????????
--???????????, ?????????????, ????????, ???????????????
--???????? ???????? in
--SELECT * FROM TABLE_NAME WHERE ID IN (1,2);
--???????????? ??????????
--?????????? ? ???????? ??????? ???????? ????????????(??? ? ?????)
DROP TABLE XXX_t;
CREATE TABLE XXX_t
    (one number(3) PRIMARY KEY, 
    two varchar2(50));
INSERT INTO XXX_t VALUES (1, 'ONE');
INSERT INTO XXX_t VALUES (2, 'TWO');
INSERT INTO XXX_t VALUES (3, 'THREE');
COMMIT;
UPDATE XXX_t SET one = 4, two = 'FOUR' WHERE one = 1;
UPDATE XXX_t SET one = 44, two = 'FOURFOUR' WHERE one = 2;
COMMIT;
SELECT
    COUNT(*) "COUNT(*)"
FROM
    "SYS"."XXX_T" "A1"
WHERE
    "A1"."TWO" = 'FOUR';
COMMIT;
DELETE FROM XXX_t WHERE two = 'FOUR';
ROLLBACK;
CREATE TABLE XXX_t_child
    (three number(3),
    four varchar(21),
    CONSTRAINT fk_supplier
        FOREIGN KEY (three)
        REFERENCES XXX_t(one));
COMMIT;
INSERT INTO XXX_t_child VALUES (1, 'test1_0');
INSERT INTO XXX_t_child VALUES (1, 'test1_1');
INSERT INTO XXX_t_child VALUES (2, 'test2_0');
COMMIT;
SELECT * FROM XXX_t xt LEFT JOIN XXX_t_child ld ON xt.one = ld.three;
SELECT * FROM XXX_t xt INNER JOIN XXX_t_child ld ON xt.one = ld.three;
--DROP TABLE XXX_t_child;
--DROP TABLE XXX_t;