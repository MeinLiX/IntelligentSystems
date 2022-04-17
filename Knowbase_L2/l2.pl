% human("Ann").
% human("George").
% human("Anton").
% human("Alexa").
% human("Valentin").
% human("Alex").
% human("Kristina").
% human("Nazarii").
% human("Lesa").
% human("Vova").
% human("Milana").

street("Lom").
street("Ban").
house(48).
house(33).
house(10).
housestreet("Lom",48).
housestreet("Lom",33).
housestreet("Ban",33).
housestreet("Ban",10).
apartment(1,("Lom",48)).
apartment(7,("Lom",48)).
apartment(8,("Lom",33)).
apartment(3,("Lom",33)).
apartment(2,("Ban",33)).
apartment(5,("Ban",33)).
apartment(4,("Ban",10)).
apartment(6,("Ban",10)).

man("George").
man("Anton").
man("Valentin").
man("Alex").
man("Nazarii").
man("Vova").
woman("Ann").
woman("Alexa").
woman("Kristina").
woman("Lesa").
woman("Milana").

cat("Franko").
cat("Bee").
dog("Cezar").

livein("Franko", (7,("Lom",48))).
livein("Bee", (2,("Ban",33))).
livein("Cezar", (6,("Ban",10))).

livein("Alex", (1,("Lom",48))).
livein("Kristina", (1,("Lom",48))).
livein("George", (7,("Lom",48))).
livein("Ann", (7,("Lom",48))).
livein("Anton", (8,("Lom",33))).
livein("Valentin", (8,("Lom",33))).

livein("Lesa", (2,("Ban",33))).
livein("Milana", (2,("Ban",33))).
livein("Alexa", (5,("Ban",33))).
livein("Nazarii", (6,("Ban",10))).
livein("Vova", (6,("Ban",10))).

have_pet(X):-(man(X);woman(X)),livein(X,XH),livein(A,XH),(cat(A);dog(A)).
roommate(X,Y):-livein(X,XH),livein(Y,YH),XH = YH.
neighborhood(X,Y):-livein(X,(XA,XH)),livein(Y,(YA,YH)),XH = YH,not(XA = YA).
live_on_the_same_street(X,Y):-livein(X,(_XA,(XS,_XH))),livein(Y,(_YA,(YS,_YH))),XS = YS.
