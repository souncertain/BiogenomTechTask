CREATE TABLE "User" (
    "Id" UUID PRIMARY KEY,
    "Name" VARCHAR(50) NOT NULL,
    "Gender" INTEGER NOT NULL,
    "BirthDate" DATE NOT NULL,
    "Promocode" VARCHAR(30),
    "Height" FLOAT,
    "Weight" FLOAT,
    "Email" VARCHAR(30),
    "Phone" VARCHAR(15)
);

CREATE TABLE "Vitamin" (
    "Id" UUID PRIMARY KEY,
    "Name" VARCHAR(30) NOT NULL,
    "Unit" VARCHAR(5),
    "DailyStandart" FLOAT,
    "DailyUserVolume" FLOAT,
    "EffectsOnTheBody" VARCHAR(350),
    "NutrionRecommendations" VARCHAR(350)
);

CREATE TABLE "Product" (
    "Id" UUID PRIMARY KEY,
    "Name" VARCHAR(30) NOT NULL,
    "Description" VARCHAR(350),
    "Note" VARCHAR(350)
);

CREATE TABLE "Report" (
    "Id" UUID PRIMARY KEY,
    "Created" DATE NOT NULL,
    "UserId" UUID NOT NULL,
    FOREIGN KEY ("UserId") REFERENCES "User"("Id") ON DELETE CASCADE
);

CREATE TABLE "VitaminReport" (
    "Id" UUID PRIMARY KEY,
    "IdVitamin" UUID NOT NULL,
    "IdReport" UUID NOT NULL,
    FOREIGN KEY ("IdVitamin") REFERENCES "Vitamin"("Id") ON DELETE CASCADE,
    FOREIGN KEY ("IdReport") REFERENCES "Report"("Id") ON DELETE CASCADE
);

CREATE TABLE "VitaminProduct" (
    "Id" UUID PRIMARY KEY,
    "VitaminId" UUID NOT NULL,
    "ProductId" UUID NOT NULL,
    "VitaminContent" FLOAT,
    "Unit" VARCHAR(5),
    FOREIGN KEY ("VitaminId") REFERENCES "Vitamin"("Id") ON DELETE CASCADE,
    FOREIGN KEY ("ProductId") REFERENCES "Product"("Id") ON DELETE CASCADE
);

-- Users
INSERT INTO "User" ("Id", "Name", "Gender", "BirthDate", "Promocode", "Height", "Weight", "Email", "Phone") VALUES
(gen_random_uuid(), 'Алиса', 1, '1995-03-12', 'PROMO2025', 165.0, 60.0, 'alice@example.com', '+79998887766'),
(gen_random_uuid(), 'Боб', 0, '1990-07-22', NULL, 180.0, 80.5, 'bob@example.com', '+79991234567');

-- Vitamins
INSERT INTO "Vitamin" ("Id", "Name", "Unit", "DailyStandart", "DailyUserVolume", "EffectsOnTheBody", "NutrionRecommendations") VALUES
(gen_random_uuid(), 'Витамин C', 'mg', 90, 75, 'Повышает иммунитет и здоровье кожи', null),
(gen_random_uuid(), 'Витамин D', 'IU', 600, 500, 'Полезно для зрения и иммунной системы', 'Печень говяжья, Печеночья колбаса, Сосиски/колбаски приготовленные, Масло сливочное, Швейцарский сыр'),
(gen_random_uuid(), 'Витамин A', 'µg', 900, 700, 'Поддерживает здоровье костей', 'Скумбрия, Сельдь, Сардины, Палтус, Лосось');

-- Products
INSERT INTO "Product" ("Id", "Name", "Description", "Note") VALUES
(gen_random_uuid(), 'Vitrum C 500mg', 'Таблетки с высокой дозой витамина С', 'Принимать по 1 таблетке в день после еды'),
(gen_random_uuid(), 'D3 Active Drops', 'Жидкая форма витамина D3', '5 капель в день'),
(gen_random_uuid(), 'A-Vit Forte', 'Капсулы с витамином А для кожи и зрения', 'Используйте по рекомендации врача');

-- Reports
WITH first_user AS (
  SELECT "Id" AS uid FROM "User" LIMIT 1
)
INSERT INTO "Report" ("Id", "Created", "UserId")
SELECT gen_random_uuid(), CURRENT_DATE, uid FROM first_user;

WITH vr AS (
  SELECT r."Id" AS rid, v."Id" AS vid
  FROM "Report" r, "Vitamin" v
  LIMIT 3
)
INSERT INTO "VitaminReport" ("Id", "IdVitamin", "IdReport")
SELECT gen_random_uuid(), vr.vid, vr.rid FROM vr;

INSERT INTO "VitaminProduct" ("Id", "VitaminId", "ProductId", "VitaminContent", "Unit")
VALUES (gen_random_uuid(), 'b70a0969-f7cc-4158-8e0d-8a359bde8560', '8cf68be2-9e92-4b85-891a-5ddb167a0d46', 500, 'mg');

INSERT INTO "VitaminProduct" ("Id", "VitaminId", "ProductId", "VitaminContent", "Unit")
VALUES (gen_random_uuid(), 'f9b16744-3e33-43b0-b505-a8e30251ea39', 'b195e1b3-0b57-4969-8b8e-b058aa0f0915', 400, 'IU');

INSERT INTO "VitaminProduct" ("Id", "VitaminId", "ProductId", "VitaminContent", "Unit")
VALUES (gen_random_uuid(), 'f4d8760e-b5e7-4d43-b6b5-8986dfc6d2de', 'c31751d0-dffd-49aa-9935-4c9a7b193c0c', 800, 'µg');

