from models.user import db

class Loan(db.Model):
    __tablename__ = "loans"

    id = db.Column(db.Integer, primary_key=True)
    user_id = db.Column(db.Integer, nullable=False)

    loan_name = db.Column(db.String(100), nullable=False)
    loan_type = db.Column(db.String(50), nullable=False)

    loan_amount = db.Column(db.Float, nullable=False)
    interest_rate = db.Column(db.Float, nullable=False)

    emi_amount = db.Column(db.Float, nullable=False)
    outstanding = db.Column(db.Float, nullable=False)

    due_date = db.Column(db.Date, nullable=False)

    status = db.Column(db.String(20), default="Pending")
