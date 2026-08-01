from models.user import db

class Investment(db.Model):
    __tablename__ = "investments"

    id = db.Column(db.Integer, primary_key=True)
    user_id = db.Column(db.Integer, nullable=False)

    name = db.Column(db.String(100), nullable=False)
    type = db.Column(db.String(50), nullable=False)

    invested_amount = db.Column(db.Float, nullable=False)
    current_value = db.Column(db.Float, nullable=False)

    purchase_date = db.Column(db.Date, nullable=False)
