from models.user import db

class Wallet(db.Model):
    __tablename__ = "wallets"

    id = db.Column(db.Integer, primary_key=True)

    user_id = db.Column(db.Integer,
                        db.ForeignKey("users.id"),
                        nullable=False)

    name = db.Column(db.String(50), nullable=False)

    balance = db.Column(db.Float, default=0)

    color = db.Column(db.String(20), default="#2563EB")
    is_active = db.Column(db.Boolean, default=True)
