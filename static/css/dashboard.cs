/* ===========================================
   PERSONAL FINANCE DASHBOARD
=========================================== */

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
    font-family:"Poppins",sans-serif;
}

body{
    background:#F4F7FC;
    color:#222;
}

.container{
    width:95%;
    max-width:1300px;
    margin:30px auto;
}

/* ================= HEADER ================= */

.header{
    display:flex;
    justify-content:space-between;
    align-items:center;
    margin-bottom:25px;
}

.welcome small{
    color:#6B7280;
    font-size:15px;
}

.welcome h2{
    margin-top:5px;
    font-size:30px;
    color:#111827;
}

.profile-btn a{
    width:55px;
    height:55px;
    display:flex;
    justify-content:center;
    align-items:center;
    border-radius:50%;
    background:#2563EB;
    color:#fff;
    font-size:24px;
    text-decoration:none;
    box-shadow:0 10px 20px rgba(37,99,235,.20);
}

.profile-btn a:hover{
    background:#1D4ED8;
}

/* ================= BALANCE CARD ================= */

.balance-card{

    background:linear-gradient(135deg,#2563EB,#1D4ED8);

    color:#fff;

    border-radius:22px;

    padding:28px;

    margin-bottom:28px;

    box-shadow:0 15px 35px rgba(37,99,235,.25);

}

.balance-card p{

    font-size:17px;

    opacity:.95;

}

.balance-card h1{

    font-size:42px;

    margin:10px 0;

    font-weight:700;

}

.balance-card span{

    font-size:16px;

}

/* ================= STATISTICS ================= */

.stats-grid{

    display:grid;

    grid-template-columns:repeat(4,1fr);

    gap:18px;

    margin-bottom:30px;

}

.stat-box{

    background:#fff;

    border-radius:18px;

    padding:22px;

    text-align:center;

    box-shadow:0 8px 20px rgba(0,0,0,.06);

}

.circle{

    width:60px;

    height:60px;

    border-radius:50%;

    display:flex;

    align-items:center;

    justify-content:center;

    margin:auto;

    color:#fff;

    font-size:24px;

    font-weight:600;

    margin-bottom:15px;

}

.green{
    background:#22C55E;
}

.red{
    background:#EF4444;
}

.blue{
    background:#2563EB;
}

.orange{
    background:#F59E0B;
}

.stat-box h4{

    color:#6B7280;

    font-size:15px;

    margin-bottom:8px;

}

.stat-box h2{

    color:#111827;

    font-size:25px;

}
/* ===========================================
   TOP BUTTONS
=========================================== */

.top-buttons{
    display:flex;
    align-items:center;
    gap:15px;
    flex-wrap:wrap;
    margin-bottom:30px;
}

.top-buttons a{
    flex:0 0 auto;
    min-width:170px;
    height:54px;

    display:flex;
    align-items:center;
    justify-content:center;

    text-decoration:none;
    color:#fff;
    font-size:15px;
    font-weight:600;

    border-radius:12px;
    transition:.25s;
    box-shadow:0 8px 18px rgba(0,0,0,.12);
}
/* ===========================================
   SEARCH BAR
=========================================== */
.search-form{
    display:grid;
    grid-template-columns:2fr 1fr 1fr;
    gap:15px;
    margin:25px 0;
}

.search-form input,
.search-form select,
.search-form button{
    height:52px;
    border:none;
    border-radius:12px;
    font-size:16px;
}

.search-form input,
.search-form select{
    background:#F3F4F6;
    padding:0 16px;
}

.search-form button{
    background:#2563EB;
    color:white;
    font-weight:600;
    cursor:pointer;
}

.search-form button:hover{
    background:#1D4ED8;
}

/* ===========================================
   RECENT TRANSACTIONS
=========================================== */

.section-title{
    font-size:28px;
    font-weight:700;
    color:#111827;
    margin:30px 0 18px;
}

/* Scroll Area */

.transactions-container{

    height:560px;

    overflow-y:auto;

    padding-right:8px;

}

/* Scrollbar */

/* Transaction Scroll */

.transactions-container{
    max-height:430px;
    overflow-y:auto;
    overflow-x:hidden;
    padding-right:8px;
    margin-top:15px;
}

.transactions-container::-webkit-scrollbar{
    width:6px;
}

.transactions-container::-webkit-scrollbar-track{
    background:#F3F4F6;
    border-radius:20px;
}

.transactions-container::-webkit-scrollbar-thumb{
    background:#2563EB;
    border-radius:20px;
}

.transactions-container::-webkit-scrollbar-thumb:hover{
    background:#1D4ED8;
}
/* Card */

.transaction-card{

    background:#fff;

    border-radius:18px;

    padding:20px;

    margin-bottom:18px;

    box-shadow:0 8px 22px rgba(0,0,0,.06);

    transition:.25s;

}

.transaction-card:hover{

    transform:translateY(-2px);

    box-shadow:0 14px 28px rgba(0,0,0,.10);

}

/* Top */

.transaction-header{

    display:flex;

    justify-content:space-between;

    align-items:flex-start;

    margin-bottom:18px;

}

.transaction-header h3{

    font-size:20px;

    color:#111827;

    margin-bottom:6px;

}

.transaction-header small{

    color:#6B7280;

    font-size:14px;

}

/* Amount */

.income-amount{

    color:#16A34A;

    font-size:24px;

    font-weight:700;

}

.expense-amount{

    color:#DC2626;

    font-size:24px;

    font-weight:700;

}

/* Recurring */

.recurring{

    display:inline-block;

    margin-top:8px;

    padding:5px 12px;

    border-radius:30px;

    background:#E0F2FE;

    color:#0369A1;

    font-size:12px;

    font-weight:600;

}

/* Buttons */

.transaction-buttons{

    display:flex;

    justify-content:flex-end;

    gap:10px;

    flex-wrap:wrap;

}

.transaction-buttons a{

    text-decoration:none;

    padding:9px 16px;

    border-radius:10px;

    color:#fff;

    font-size:14px;

    font-weight:600;

}

.edit-btn{

    background:#2563EB;

}

.edit-btn:hover{

    background:#1D4ED8;

}

.delete-btn{

    background:#EF4444;

}

.delete-btn:hover{

    background:#DC2626;

}

.receipt-btn{

    background:#10B981;

}

.receipt-btn:hover{

    background:#059669;

}

/* Empty */

.no-transactions{

    background:#fff;

    padding:40px;

    border-radius:18px;

    text-align:center;

    color:#6B7280;

    font-size:18px;

    box-shadow:0 8px 20px rgba(0,0,0,.06);

}
/* ===========================================
   CHARTS
=========================================== */

.charts-section{

    display:grid;

    grid-template-columns:repeat(2,1fr);

    gap:25px;

    margin-top:35px;

}

.chart-card{

    background:#fff;

    border-radius:20px;

    padding:25px;

    box-shadow:0 10px 25px rgba(0,0,0,.06);

}

.chart-card h3{

    text-align:center;

    margin-bottom:20px;

    color:#111827;

    font-size:20px;

}

.chart-card canvas{

    width:100% !important;

    max-height:320px !important;

}

/* ===========================================
   MOBILE
=========================================== */

@media(max-width:900px){

.stats-grid{

grid-template-columns:repeat(2,1fr);

}

.charts-section{

grid-template-columns:1fr;

}

}

@media(max-width:768px){

.container{

width:96%;

}

.header{

flex-direction:column;

align-items:flex-start;

gap:15px;

}

.balance-card h1{

font-size:34px;

}

.top-buttons{

flex-direction:column;

}

.top-buttons a{

width:100%;

}

.transaction-header{

flex-direction:column;

gap:10px;

}

.transaction-buttons{

justify-content:flex-start;

}

}

@media(max-width:480px){

.stats-grid{

grid-template-columns:1fr;

}

.welcome h2{

font-size:24px;

}

.balance-card h1{

font-size:28px;

}

.transaction-card{

padding:18px;

}

.transaction-buttons{

flex-direction:column;

}

.transaction-buttons a{

width:100%;

text-align:center;

}

}

/* ===========================================
   ANIMATION
=========================================== */

.balance-card,
.stat-box,
.chart-card,
.transaction-card{

animation:fade .4s ease;

}

@keyframes fade{

from{

opacity:0;

transform:translateY(15px);

}

to{

opacity:1;

transform:translateY(0);

}

}
/* ================= PREMIUM UI ================= */

body{
    background:#EEF4FA;
}

/* Cards */

.balance-card,
.stat-box,
.chart-card,
.transaction-card{

    border:1px solid rgba(0,0,0,.04);

}

/* Hover */

.stat-box:hover,
.chart-card:hover,
.transaction-card:hover{

    transform:translateY(-4px);

    transition:.3s;

    box-shadow:0 18px 40px rgba(0,0,0,.12);

}


/* Transaction Amount */

.income-amount,
.expense-amount{

    min-width:120px;

    text-align:right;

}

/* Buttons */

.transaction-buttons{

    margin-top:12px;

}

.transaction-buttons a{

    min-width:110px;

    text-align:center;

}

/* Top Buttons */

.top-buttons{

    margin-top:25px;

    margin-bottom:30px;

}

.top-buttons a{

    border-radius:14px;

    letter-spacing:.3px;

}

/* Charts */

.chart-card{

    transition:.3s;

}

.chart-card:hover{

    transform:translateY(-4px);

}

/* Scrollbar */

.transactions-container{

    scroll-behavior:smooth;

}

.transactions-container::-webkit-scrollbar{

    width:7px;

}

.transactions-container::-webkit-scrollbar-thumb{

    background:#3B82F6;

    border-radius:20px;

}

.transactions-container::-webkit-scrollbar-track{

    background:#E5E7EB;

}
.loan-btn{
    display:flex;
    justify-content:center;
    align-items:center;

    background:#10B981 !important;
    color:#fff !important;

    height:55px;
    padding:0 22px;

    border-radius:12px;

    text-decoration:none !important;
    font-weight:600;
    font-size:15px;

    box-shadow:0 4px 12px rgba(16,185,129,.3);
    transition:.3s;
}

.loan-btn:hover{
    background:#059669 !important;
    transform:translateY(-2px);
}
/* Three Dots Menu */

.fab-menu{
    position:relative;
    margin-left:auto;
}

.menu-btn{
    width:50px;
    height:50px;
    border:none;
    border-radius:12px;
    background:#2563EB;
    color:#fff;
    font-size:24px;
    cursor:pointer;
}

.menu{
    display:none;
    position:absolute;
    top:60px;
    right:0;
    width:220px;
    background:#fff;
    border-radius:12px;
    box-shadow:0 8px 20px rgba(0,0,0,.15);
    z-index:9999;
}

