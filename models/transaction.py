from models.user import db

class Transaction(db.Model):
    __tablename__ = "transactions"

    id = db.Column(db.Integer, primary_key=True)
    user_id = db.Column(db.Integer, nullable=False)
    type = db.Column(db.String(20), nullable=False)
    category = db.Column(db.String(100), nullable=False)
    amount = db.Column(db.Float, nullable=False)
    note = db.Column(db.String(255))
    recurring = db.Column(db.Boolean, default=False)
    frequency = db.Column(db.String(20))
    next_due = db.Column(db.Date)
    receipt = db.Column(db.String(255))
    date = db.Column(db.Date, nullable=False)
    wallet_id = db.Column(
    db.Integer,
    db.ForeignKey("wallets.id"),
    nullable=True
    )
