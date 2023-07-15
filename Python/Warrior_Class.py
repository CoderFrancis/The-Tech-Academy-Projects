#this is the category of the players the user gets to pick from.
#They can either choose a warrior or stealth class.

#the information is waiting for user input.
#parent class.
class Player:
    name = input("Enter your name: ")
    age = input("Enter your age: ")
    clan = input("Enter your clan: ")
    

#the description and attributes of the warrior class.
class Warrior(Player):
    weapon = 'long_sword'
    dmg = '100'
    fighting_stlye = 'Brass, loud, flashy. This character likes to fight up close and personal.'

#the description and attributes of the stealth class.
class Stealth(Player):
    weapon = 'daggers'
    dmg = '10'
    fighting_stlye = 'Silent, discreet, concise. This character embraces the element of surprise.'
    
    
    
