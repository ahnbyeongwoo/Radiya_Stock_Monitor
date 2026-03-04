# 📦 Odoo ERP 연동 실시간 재고 모니터링 시스템
> **PostgreSQL DB와 C# WinForms를 활용한 ERP 툴 개발 프로젝트**

## 프로젝트 개요
* **목적**: Odoo ERP 체험판 운영 중 발생할 수 있는 데이터 누락 및 재고 부족 상황을 실시간으로 감지하여 관리자에게 알림을 제공.
* **주요 기능**: 
    * PostgreSQL 원격 데이터베이스 연동 및 실시간 쿼리 수행.
    * 설정된 안전 재고(5개) 미만 품목 자동 필터링 및 대시보드 출력.
    * 재고 부족 시 즉각적인 시스템 경고 메시지 팝업.

## 기술 스택 (Tech Stack)
* **Language**: C#
* **Framework**: .NET Windows Forms
* **Database**: PostgreSQL
* **Library**: Npgsql

## 시스템 아키텍처
* **Server**: Ubuntu 기반의 Odoo ERP 서버 및 PostgreSQL DB 운영.
* **Client**: Npgsql 라이브러리를 통해 외부 대역에서 DB 접근 제어 정책(pg_hba.conf)을 통과하여 데이터를 수집.

### 🛰️ 원격 DB 접속 보안 설정
* **문제**: 외부 IP 접속 시 PostgreSQL 인증 실패(`28P01`) 오류.
* **해결**: `pg_hba.conf`의 접근 제어 목록(ACL) 수정 및 인증 방식 최적화를 통해 보안과 연결성 확보.

## 5. 최종 시연
* 버튼 클릭 시 실시간으로 ERP 재고 데이터를 호출하여 대시보드 업데이트 완료.
