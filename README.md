# BalanceBord
Здраствуйте, уважаемые жюри! Вас вновь приветствует команда FTIT!
Мы представляем вам игру в жанре "BalanceBoard" в стиле "Надежных паролей"!
Вам предстоит балансировать между надежностью и сложностью запоминания! (метафорично)
В верхней части главной игровой сцены есть счетчик, чтобы знать, сколько вы продержались!
Осторожно! Игра со временем усложняется: нельзя вечно одинаково успешно балансировать,
со временем, "пользователь борда" (которого не видно) начинает делать ошибки, что проявляется как резкое надавливание
на одну из сторон борда. Чем дольше вы продержались, тем чаще "пользователь борда" начинает делать ошибки.

Доп.объяснение: усложнение реализовано посредством приложения к одной из сторон (которая выбирается рандомайзером)
силы (уровень которой так же выбирается рандомайзером в заданном диапазоне). Сначала это происходит раз в 5 секунд.
Далее каждые 15 секунд количество силы уменьшается на 1, пока не достигнет 1. Т.е. на самом сложном уровне спустя 
60 секунд контролировать борд становиться крайне сложно, и,ё чтобы не проиграть, надо всегда держать борд горизонтально,
и быстро возвращать в это положение в случае возникновения "силы усталости пользователя борда".
(Механика усложнения находится в методе FixedUpdate() скрипта BoardController и помечена комментарием "УСЛОЖНЕНИЕ 
СО ВРЕМЕНЕМ").

Спасибо, и хорошей игры!